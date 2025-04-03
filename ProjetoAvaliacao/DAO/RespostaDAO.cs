using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliacao.DAO
{
    public class RespostaDAO
    {
        public static DataTable RespostasFunc(int codperg, int codfunc, int codgrupo)
        {
            string sql = $"select r.idpergunta, r.codperg,(select pergunta from fstperguntarh where r.idpergunta = idpergunta) pergunta, r.respostafunc, r.comentariofunc, r.acoesgestor, r.dtprazo,r.observacao from fstrespostasrh r where r.codperg = {codperg} and r.codfunc = {codfunc} and r.codgrupo = {codgrupo} ";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static void FinalizarRespostas(int codGrupo, int codFunc, int codPerg, int respostaGestor, int idPesq)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstrespostasrh (CODIGO, CODGRUPO, CODPERG, RESPOSTAGESTOR, DTFINALIZA, CODFUNC, IDPERGUNTA, AVALEXP)
                                        VALUES (:codigo, :codgrupo, :codperg, :respostagestor, sysdate, :codfunc, :idpesq, 'S')";

                int codigo = CodigoResposta();

                cmdPagar.Parameters.AddWithValue(":codigo", codigo);
                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                cmdPagar.Parameters.AddWithValue(":codperg", codPerg);
                cmdPagar.Parameters.AddWithValue(":respostagestor", respostaGestor);
                cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                cmdPagar.Parameters.AddWithValue(":idpesq", idPesq);

                cmdPagar.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        
        public static void RespostasAnaliseGestor(int codGrupo, int codFunc, int codPerg, int respostaGestor, string observacao, string acoesgestor, int idPesq, DateTime data)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"UPDATE fstrespostasrh SET
                                            RESPOSTAGESTOR = :respostagestor,
                                            ACOESGESTOR = :acaogestor,
                                            OBSERVACAO = :observacao,
                                            DTPRAZO = TO_DATE(:data, 'DD/MM/YYYY')
                                            where codperg = :codperg
                                            and codfunc = :codfunc 
                                            and codgrupo = :codgrupo
                                            and idpergunta = :idpesq";

                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                cmdPagar.Parameters.AddWithValue(":codperg", codPerg);
                cmdPagar.Parameters.AddWithValue(":respostagestor", respostaGestor);
                cmdPagar.Parameters.AddWithValue(":acaogestor", acoesgestor);
                cmdPagar.Parameters.AddWithValue(":observacao", observacao);
                cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                cmdPagar.Parameters.AddWithValue(":idpesq", idPesq);
                cmdPagar.Parameters.AddWithValue(":data", data);

                cmdPagar.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        
        public static void AvaliacaoFinalizada(int avaliacao)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"UPDATE fstavaliacaorh SET
                                            RESPONDIDO = 'S'
                                            WHERE IDAVALIACAO = :avaliacao";

                cmdPagar.Parameters.AddWithValue(":avaliacao", avaliacao);

                cmdPagar.ExecuteNonQuery();

                transacao.Commit();
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static int CodigoResposta()
        {
            string sql = @"select max(codigo) + 1 from fstrespostasrh";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0]);
        }
    }
}
