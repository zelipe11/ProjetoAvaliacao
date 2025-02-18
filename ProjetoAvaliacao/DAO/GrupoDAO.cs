using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliacao.DAO
{
    public class GrupoDAO
    {
        public static DataTable TabelaDeGrupos()
        {
            string sql = "select descricao, tipopesquisa from fstgruporh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static int CodGrupo()
        {
            string sql = "select max(nvl(codgrupo, 0)) + 1 from fstgruporh";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public static bool InserirGrupo(string descricao, int tipoPesquisa)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstgruporh (CODGRUPO, DESCRICAO, TIPOPESQUISA)
                                        VALUES (:codgrupo, :descricao, :tipopesquisa) ";

                int codGrupo = CodGrupo();

                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                cmdPagar.Parameters.AddWithValue(":descricao", descricao);
                cmdPagar.Parameters.AddWithValue(":tipopesquisa", tipoPesquisa);

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
