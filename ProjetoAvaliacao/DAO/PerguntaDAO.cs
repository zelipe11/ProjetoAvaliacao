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
    public class PerguntaDAO
    {
        public static int ValorPergunta()
        {
            string sql = "SELECT COALESCE(MAX(ID), 0) + 1 FROM fstperguntarh";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value
                ? Convert.ToInt32(dt.Rows[0][0])
                : 1;
        }

        public static int ValorId()
        {
            string sql = "SELECT COALESCE(MAX(IDPERGUNTA), 0) + 1 FROM fstperguntarh";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value
                ? Convert.ToInt32(dt.Rows[0][0])
                : 1;
        }

        public static void AdicionarPerguntas(int idPergunta, string descricaoPesq, int codGrupo, int tipoPesq, string tipoPerg, string pergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstperguntarh (ID, DESCRICAOPESQ, CODGRUPO, TIPOPESQ, TIPOPERG, PERGUNTA, IDPERGUNTA)
                                        VALUES(:id, :descricaopesq, :codgrupo, :tipopesq, :tipoperg, :pergunta, :idpergunta)";

                int id = ValorId();

                cmdPagar.Parameters.AddWithValue(":id", idPergunta);
                cmdPagar.Parameters.AddWithValue(":descricaopesq", descricaoPesq);
                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                cmdPagar.Parameters.AddWithValue(":tipopesq", tipoPesq);
                cmdPagar.Parameters.AddWithValue(":tipoperg", tipoPerg);
                cmdPagar.Parameters.AddWithValue(":pergunta", pergunta);
                cmdPagar.Parameters.AddWithValue(":idpergunta", id);


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

        public static DataTable Pergunta(int idpergunta)
        {
            string sql = $"select pergunta, tipoperg from fstperguntarh where idpergunta = {idpergunta}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable PerguntasDaPesquisa(int id)
        {
            string sql = $@"select p.descricaopesq, p.codgrupo, (select descricao from fstgruporh where p.codgrupo = codgrupo) grupo, (select descricao from fsttipopesqrh where p.tipopesq = codpesq) tppesq, 
                            CASE WHEN p.tipoperg = 'N' then 'NUMERICA' WHEN p.tipoperg = 'T' then 'TEXTO' END AS formatopesq, p.pergunta, p.idpergunta from fstperguntarh p where p.id = {id} and dtexclusao is null";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static void ExcluirPergunta(int idPergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"UPDATE fstperguntarh SET
                                            DTEXCLUSAO = sysdate
                                            WHERE IDPERGUNTA = :idpergunta";


                cmdPagar.Parameters.AddWithValue(":idpergunta", idPergunta);

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
        
        public static void EditarPergunta(string pergunta, string tipoPerg, int idPergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"UPDATE fstperguntarh SET
                                            pergunta = :pergunta,
                                            tipoperg = :tipoperg
                                            WHERE IDPERGUNTA = :idpergunta";


                cmdPagar.Parameters.AddWithValue(":idpergunta", idPergunta);
                cmdPagar.Parameters.AddWithValue(":pergunta", pergunta);
                cmdPagar.Parameters.AddWithValue(":tipoperg", tipoPerg);

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
    }
}
