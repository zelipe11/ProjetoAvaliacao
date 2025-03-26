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
            string sql = "select codgrupo, descricao, tipopesquisa from fstgruporh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable TabelaDePesquisa(int codGrupo)
        {
            string sql = $"select * from fsttipopesqrh where idgrupo = {codGrupo}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static int CodPesq()
        {
            string sql = "select COALESCE(max(codpesq), 0) + 1 from fsttipopesqrh";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public static bool InserirTPPesq(string descricao, int tipoPesquisa)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fsttipopesqrh (CODPESQ, DESCRICAO, IDGRUPO)
                                        VALUES (:codgrupo, :descricao, :tipopesquisa) ";

                int codGrupo = CodPesq();

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

        public static void AtualizarTipoPesq(int IdPesq, string pesq)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"UPDATE fsttipopesqrh SET
                                        DESCRICAO = :descri
                                        WHERE CODPESQ = :codpesq";


                cmdPagar.Parameters.AddWithValue(":codpesq", IdPesq);
                cmdPagar.Parameters.AddWithValue(":descri", pesq);


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
