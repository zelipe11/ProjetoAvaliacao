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
            string sql = "select max(nvl(ID, 0)) + 1 from fstperguntarh";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public static bool AdicionarPerguntas(int idPergunta, string descricaoPesq, int codGrupo, int tipoPesq, string tipoPerg, string pergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstperguntarh (ID, DESCRICAOPESQ, CODGRUPO, TIPOPESQ, TIPOPERG, PERGUNTA)
                                        VALUES(:idpergunta, :descricaopesq, :codgrupo, :tipopesq, :tipoperg, :pergunta)";

                

                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);


                cmdPagar.ExecuteNonQuery();

                transacao.Commit();

                return true;
            }
            catch (Exception erro)
            {
                transacao.Rollback();
                return false;
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
