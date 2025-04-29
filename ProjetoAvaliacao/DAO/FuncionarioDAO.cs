using FuncoesWinthor;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.DAO
{
    public class FuncionarioDAO
    {
        public static DataTable Funcionarios()
        {
            string sql = "select * from fstpesqrh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static void SalvarExcel(string filePath)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                try
                {
                    OracleCommand comando = conexao.CreateCommand();
                    comando.Transaction = transacao;

                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {

                        if (!worksheet.Cells[row, 1, row, worksheet.Dimension.End.Column].Any(c => !string.IsNullOrEmpty(c.Text)))
                            break;

                        int codigo = Convert.ToInt32(worksheet.Cells[row, 1].Text);
                        string nome = worksheet.Cells[row, 2].Text;
                        string funcao = worksheet.Cells[row, 3].Text;
                        string admissao = ConverterDataOuNula(worksheet.Cells[row, 5].Text);
                        string demissao = ConverterDataOuNula(worksheet.Cells[row, 6].Text);
                        string vencContrato = ConverterDataOuNula(worksheet.Cells[row, 7].Text);
                        string vencProrrogacao = ConverterDataOuNula(worksheet.Cells[row, 8].Text);
                        string CPF = worksheet.Cells[row, 9].Text;
                        string salario = worksheet.Cells[row, 11].Text;
                        string salarioFormatado = salario.Replace("/M", "").Trim();

                        double? smQtde = ObterDoubleOuNulo(worksheet.Cells[row, 16].Text);
                        double? smValor = ObterDoubleOuNulo(worksheet.Cells[row, 17].Text);
                        double? amhQtde = ObterDoubleOuNulo(worksheet.Cells[row, 18].Text);
                        double? amhValor = ObterDoubleOuNulo(worksheet.Cells[row, 19].Text);
                        double? amQtde = ObterDoubleOuNulo(worksheet.Cells[row, 20].Text);
                        double? amValor = ObterDoubleOuNulo(worksheet.Cells[row, 21].Text);
                        double? dfQtde = ObterDoubleOuNulo(worksheet.Cells[row, 22].Text);
                        double? dfValor = ObterDoubleOuNulo(worksheet.Cells[row, 23].Text);
                        double? dfaQtde = ObterDoubleOuNulo(worksheet.Cells[row, 24].Text);
                        double? dfaValor = ObterDoubleOuNulo(worksheet.Cells[row, 25].Text);
                        int setor = Convert.ToInt32(worksheet.Cells[row, 28].Text);
                        string gestor = worksheet.Cells[row, 29].Text;
                        int codgestor = Convert.ToInt32(worksheet.Cells[row, 30].Text);

                        comando.CommandText = $@"INSERT INTO fstpesqrh (CODIGO,NOME,FUNCAO,DTADMISSAO,DTDEMISSAO,DTVENCCONTRATO,DTVENCCONTRATOPROG,
                        CPF,SALARIO,SALMESQTDE,SALMESVALOR,ATESTADOQTDE,ATESTADOVALOR,ATESTADOQTDEH,ATESTADOVALORH,FALTASQTDEH,
                        FALTASVALORH,AUSENCIAQTDEH,AUSENCIAVALORH,MES, SETOR, GESTOR, CODGESTOR) 
                        VALUES({codigo},'{nome}','{funcao}',TO_DATE('{admissao}', 'YYYY-MM-DD HH24:MI:SS'),
                        TO_DATE('{demissao}', 'YYYY-MM-DD HH24:MI:SS'),TO_DATE('{vencContrato}', 'YYYY-MM-DD HH24:MI:SS'),
                        TO_DATE('{vencProrrogacao}', 'YYYY-MM-DD HH24:MI:SS'),'{CPF}',to_number('{salarioFormatado}','99999D99','NLS_NUMERIC_CHARACTERS ='', '''),
                        to_number('{smQtde}','99999D99','NLS_NUMERIC_CHARACTERS ='', '''),to_number('{smValor}','99999D99','NLS_NUMERIC_CHARACTERS ='', '''),
                        to_number('{amhQtde}','99999D99','NLS_NUMERIC_CHARACTERS ='', '''),to_number('{amhValor}','9999D99','NLS_NUMERIC_CHARACTERS ='', '''),
                        to_number('{amQtde}','99999D99','NLS_NUMERIC_CHARACTERS ='', '''),to_number('{amValor}','9999D99','NLS_NUMERIC_CHARACTERS ='', '''),
                        to_number('{dfQtde}','99999D99','NLS_NUMERIC_CHARACTERS ='', '''),to_number('{dfValor}','9999D99','NLS_NUMERIC_CHARACTERS ='', '''),
                        to_number('{dfaQtde}','99999D99','NLS_NUMERIC_CHARACTERS ='', '''),to_number('{dfaValor}','9999D99','NLS_NUMERIC_CHARACTERS ='', '''),
                        sysdate, {setor}, '{gestor}', {codgestor})";

                        comando.ExecuteNonQuery();
                    }

                    transacao.Commit();
                }
                catch (Exception erro)
                {
                    transacao.Rollback();
                    MessageBox.Show($"Erro ao salvar dados: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw erro;
                }
                finally
                {
                    conexao.Close();
                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static string ConverterDataOuNula(string dataTexto)
        {
            if (dataTexto == "__/__/____")
                return null;

            if (DateTime.TryParse(dataTexto, out DateTime data))
                return data.ToString("yyyy-MM-dd HH:mm:ss");

            return null;
        }

        private static double? ObterDoubleOuNulo(string valorTexto)
        {
            if (string.IsNullOrWhiteSpace(valorTexto))
                return 0;

            try
            {
                return Convert.ToDouble(valorTexto);
            }
            catch (FormatException)
            {
                return null;
            }
        }
    }
}
