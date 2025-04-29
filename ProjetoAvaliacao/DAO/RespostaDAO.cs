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
            string sql = $"select r.codigo ,r.idpergunta, r.codperg,(select pergunta from fstperguntarh where r.idpergunta = idpergunta) pergunta, r.respostafunc, r.comentariofunc, r.acoesgestor, r.dtprazo,r.observacao from fstrespostasrh r where r.codperg = {codperg} and r.codfunc = {codfunc} and r.codgrupo = {codgrupo} ";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static bool ExisteRespostaFinalizada(int codgrupo, int codfunc, int codperg, int idPesq)
        {
            string sql = $"select * from fstrespostasrh where codgrupo = {codgrupo} and codfunc = {codfunc} and codperg = {codperg} and idpergunta = {idPesq} and dtfinalizagestor is not null";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;

            else
                return false;
        }

        public static void FinalizarRespostas(int codGrupo, int codFunc, int codPerg, string respostaGestor, int idPesq)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"INSERT INTO fstrespostasrh (CODIGO, CODGRUPO, CODPERG, RESPOSTAFUNC, DTFINALIZA, CODFUNC, IDPERGUNTA, AVALEXP)
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
        
        public static void RespostasSalvasAnaliseGestor(int codGrupo, int codFunc, int codPerg, int? respostaGestor, string observacao, string acoesgestor, int idPesq, DateTime? data)
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
                                            DTPRAZO = TO_DATE(:dtprazo, 'dd/MM/yyyy'),
                                            DTSALVAGESTOR = sysdate
                                            where codperg = :codperg
                                            and codfunc = :codfunc 
                                            and codgrupo = :codgrupo
                                            and idpergunta = :idpesq";

                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                cmdPagar.Parameters.AddWithValue(":codperg", codPerg);

                if (respostaGestor != null)
                    cmdPagar.Parameters.AddWithValue(":respostagestor", respostaGestor);
                else
                    cmdPagar.Parameters.AddWithValue(":respostagestor", DBNull.Value);

                cmdPagar.Parameters.AddWithValue(":acaogestor", acoesgestor.Trim());
                cmdPagar.Parameters.AddWithValue(":observacao", observacao.Trim());
                cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                cmdPagar.Parameters.AddWithValue(":idpesq", idPesq);

                if (data != null)
                    cmdPagar.Parameters.AddWithValue(":dtprazo", data);
                else
                    cmdPagar.Parameters.AddWithValue(":dtprazo", DBNull.Value);

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
        
        public static void RespostasFinalizaAnaliseGestor(int codGrupo, int codFunc, int codPerg, int? respostaGestor, string observacao, string acoesgestor, int idPesq, DateTime? data)
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
                                            DTPRAZO = TO_DATE(:dtprazo, 'dd/MM/yyyy'),
                                            DTFINALIZAGESTOR = sysdate,
                                            where codperg = :codperg
                                            and codfunc = :codfunc 
                                            and codgrupo = :codgrupo
                                            and idpergunta = :idpesq";

                cmdPagar.Parameters.AddWithValue(":codgrupo", codGrupo);
                cmdPagar.Parameters.AddWithValue(":codperg", codPerg);

                if (respostaGestor != null)
                    cmdPagar.Parameters.AddWithValue(":respostagestor", respostaGestor);
                else
                    cmdPagar.Parameters.AddWithValue(":respostagestor", DBNull.Value);

                cmdPagar.Parameters.AddWithValue(":acaogestor", acoesgestor.Trim());
                cmdPagar.Parameters.AddWithValue(":observacao", observacao.Trim());
                cmdPagar.Parameters.AddWithValue(":codfunc", codFunc);
                cmdPagar.Parameters.AddWithValue(":idpesq", idPesq);

                if (data != null)
                    cmdPagar.Parameters.AddWithValue(":dtprazo", data);
                else
                    cmdPagar.Parameters.AddWithValue(":dtprazo", DBNull.Value);

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

        public static bool ExisteRespostaSalva(int codgrupo, int codfunc, int codperg, int idpesq)
        {
            string sql = $"select * from fstrespostasrh where codgrupo = {codgrupo} and codfunc = {codfunc} and codperg = {codperg} and idpergunta = {idpesq} and avalexp is null";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static DataTable RespostasSalvas(int codPerg, int codGrupo, int codFunc, int idPesq)
        {
            string sql = $"select respostagestor from fstrespostasrh where codperg = {codPerg} and codgrupo = {codGrupo} and codfunc = {codFunc} and idpergunta = {idPesq} and AVALEXP is null";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
