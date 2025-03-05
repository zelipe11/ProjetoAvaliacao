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
    public class AvaliacaoDAO
    {
        public static DataTable Avaliacoes(int codsetor)
        {
            string sql = $@"select a.idavaliacao, a.codfunc, p.nome funcionario, a.dtinicio, a.dtfim, a.idpergunta 
                            from fstavaliacaorh a , fstpesqrh p
                            where p.codigo = a.codfunc
                            and a.dtinicio <= sysdate
                            and a.dtfim >= sysdate
                            and p.setor = {codsetor}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable Grupos(int idpergunta)
        {
            string sql = $"select p.codgrupo, g.descricao from fstperguntarh p, fstgruporh g where p.codgrupo = g.codgrupo and id = {idpergunta} group by p.codgrupo, g.descricao";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable Perguntas(int codgrupo)
        {
            string sql = $"select p.IDPERGUNTA, p.ID, p.PERGUNTA, (select respostagestor from fstrespostasrh where p.idpergunta = idpergunta and p.id = codperg and avalexp = 'S') resposta from fstperguntarh p where p.codgrupo = {codgrupo}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable PeriodosAvalia()
        {
            string sql = "select * from fstperiodorh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static bool AdicionarPeriodo(int periodo1, int periodo2, int periodo3, int periodo4, int periodo5)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdPagar = conexao.CreateCommand();
                cmdPagar.Transaction = transacao;

                cmdPagar.CommandText = @"UPDATE FSTPERIODORH SET
                                            PERIODO1 = :periodo1
                                            PERIODO2 = :periodo2
                                            PERIODO3 = :periodo3
                                            PERIODO4 = :periodo4
                                            PERIODO5 = :periodo5"
                ;

                cmdPagar.Parameters.AddWithValue(":periodo1", periodo1);
                cmdPagar.Parameters.AddWithValue(":periodo2", periodo2);
                cmdPagar.Parameters.AddWithValue(":periodo3", periodo3);
                cmdPagar.Parameters.AddWithValue(":periodo4", periodo4);
                cmdPagar.Parameters.AddWithValue(":periodo5", periodo5);


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
