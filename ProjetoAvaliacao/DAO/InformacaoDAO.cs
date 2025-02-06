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
            string sql = "select codsetor, descricao from pcsetor";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
