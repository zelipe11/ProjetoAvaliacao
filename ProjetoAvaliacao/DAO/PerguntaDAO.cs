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

        public static void AdicionarPerguntas(int idPergunta, string descricaoPesq, int codGrupo, int tipoPesq, string tipoPerg, string pergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstperguntarh (ID, DESCRICAOPESQ, CODGRUPO, TIPOPESQ, TIPOPERG, PERGUNTA)
                                        VALUES(:idpergunta, :descricaopesq, :codgrupo, :tipopesq, :tipoperg, :pergunta)";


                cmdPagar.Parameters.AddWithValue(":idpergunta", idPergunta);
                cmdPagar.Parameters.AddWithValue(":descricaopesq", descricaoPesq);
                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                cmdPagar.Parameters.AddWithValue(":tipopesq", tipoPesq);
                cmdPagar.Parameters.AddWithValue(":tipoperg", tipoPerg);
                cmdPagar.Parameters.AddWithValue(":pergunta", pergunta);


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
