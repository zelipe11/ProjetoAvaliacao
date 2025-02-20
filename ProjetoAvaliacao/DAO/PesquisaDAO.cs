using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliacao.DAO
{
    public class PesquisaDAO
    {
        public static void InserirPesquisa(int codPesquisa, string descricaoPesq, string tipoPesq, int tipoAvaliacao, string formato, DateTime dtInicio, DateTime dtFim, int codSetor, int idPergunta)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstpesquisarh (CODPESQ, DESCRICAOPESQ, TIPOPESQ, TIPOAVALIA, FORMATO, DTINICIO, DTFIM, CODSETOR, IDPERGUNTA)
                                        VALUES(:codpesquisa, :descricaopesq, :tipopesq, :tipoavalia, :formato, :dtinicio, :dtfim, :codsetor, :idpergunta)";


                cmdPagar.Parameters.AddWithValue(":codpesquisa", codPesquisa);
                cmdPagar.Parameters.AddWithValue(":descricaopesq", descricaoPesq);
                cmdPagar.Parameters.AddWithValue(":tipopesq", tipoPesq);
                cmdPagar.Parameters.AddWithValue(":tipoavalia", tipoAvaliacao);
                cmdPagar.Parameters.AddWithValue(":formato", formato);
                cmdPagar.Parameters.AddWithValue(":dtinicio", dtInicio);
                cmdPagar.Parameters.AddWithValue(":dtfim", dtFim);

                if (codSetor != 0)
                    cmdPagar.Parameters.AddWithValue(":codsetor", codSetor);
                else
                    cmdPagar.Parameters.AddWithValue(":codsetor", DBNull.Value);

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
    }
}
