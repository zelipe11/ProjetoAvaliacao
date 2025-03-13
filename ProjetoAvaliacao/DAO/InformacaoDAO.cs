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
    public class InformacaoDAO
    {
        public static DataTable PegarSetores()
        {
            string sql = "select codsetor, descricao from fstsetorrh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static DataTable PegarTipoPesq()
        {
            string sql = "select codpesq, descricao from fsttipopesqrh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable PegarTipoPesqGrupo(int codGrupo)
        {
            string sql = $"select p.codpesq, p.descricao from fsttipopesqrh p, fstgruporh g where p.codpesq = g.tipopesquisa and g.codgrupo = {codGrupo}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable PegarGrupos()
        {
            string sql = "select codgrupo, descricao from fstgruporh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static int SequencialPesquisa()
        {
            string sql = "select COALESCE(MAX(codpesq),0) + 1 from fstpesquisarh ";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value
                ? Convert.ToInt32(dt.Rows[0][0])
                : 1;
        }
        
        public static int SequencialAvaliacao()
        {
            string sql = "select COALESCE(MAX(IDAVALIACAO),0) + 1 from fstavaliacaorh ";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value
                ? Convert.ToInt32(dt.Rows[0][0])
                : 1;
        }

        public static DataTable TipoAvaliacao()
        {
            string sql = "select codavali, descricao from fstavaliadoresrh";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable Funcionarios(int setor)
        {
            string sql = $"select codigo, nome from fstpesqrh where setor = {setor}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable FuncionariosNome(int cod)
        {
            string sql = $"select nome from fstpesqrh where codigo = {cod}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable FuncionariosNomeCargo(int cod)
        {
            string sql = $"select nome, funcao from fstpesqrh where codigo = {cod}";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }

        public static bool ExisteCPF(string cpf, string senha)
        {
            string sql = $"select p.* from fstpesqrh p where REPLACE(REPLACE(p.CPF, '.', ''), '-', '') = '{cpf}' and p.senha = '{senha}' and p.gestor = 'S'";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static bool ExisteSenha(string cpf)
        {
            string sql = $"select * from fstpesqrh p where REPLACE(REPLACE(p.CPF, '.', ''), '-', '') = '{cpf}' and p.senha is not null and p.gestor = 'S'";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static int SetorDoUsuario(string cpf)
        {
            string sql = $"select setor from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}'";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public static bool TemSenha(string cpf)
        {
            string sql = $@"select case when (select senha from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}') is not null
                            then 1 else 0 end as senhauser from dual";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 1)
                return true;
            else
                return false;
        }

        public static bool TemCpf(string cpf)
        {
            string sql = $@"select case when exists (select cpf from fstpesqrh where REPLACE(REPLACE(CPF, '.', ''), '-','') = '{cpf}' and gestor = 'S')
                            then 1 else 0 end as cpfuser from dual";

            DataTable dt = MetodosDB.ExecutaSelect(sql, "FESTPAN");

            if (Convert.ToInt32(dt.Rows[0][0].ToString()) == 1)
                return true;
            else
                return false;
        }

        public static void CriarSenha(string cpf, string senha)
        {
            OracleConnection conexao = ConexaoDB.GetConexaoProd();
            OracleTransaction transacao = conexao.BeginTransaction();

            try
            {
                OracleCommand cmdSenha = conexao.CreateCommand();
                cmdSenha.Transaction = transacao;

                cmdSenha.CommandText = @"UPDATE fstpesqrh set
                                            senha = :senha
                                            where REPLACE(REPLACE(CPF, '.', ''), '-','') = :cpf";


                cmdSenha.Parameters.AddWithValue(":cpf", cpf);
                cmdSenha.Parameters.AddWithValue(":senha", senha);

                cmdSenha.ExecuteNonQuery();

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
