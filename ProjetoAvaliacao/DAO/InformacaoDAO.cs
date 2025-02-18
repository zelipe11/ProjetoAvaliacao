using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
