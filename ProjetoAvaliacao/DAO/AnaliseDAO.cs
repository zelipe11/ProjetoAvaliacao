using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliacao.DAO
{
    public class AnaliseDAO
    {
        public static DataTable RespostasSetor(int codSetor)
        {
            string sql = $@"select p.codpesq, p.descricaopesq, r.codgrupo, g.descricao descgrupo,
                            r.codfunc,
                            (select nome from fstpesqrh where codigo = r.codfunc) funcionario,
                            TO_DATE(r.dtfinaliza, 'DD/MM/YYYY') dtresposta,
                            p.idpergunta

                            from fstpesquisarh p, fstperguntarh pp, 
                            fstrespostasrh r , fstgruporh g

                            where p.codsetor = {codSetor}
                            and p.idpergunta = pp.id 
                            and pp.idpergunta = r.idpergunta 
                            and r.codgrupo = g.codgrupo
                            and r.dtfinaliza is not null
                            group by r.codfunc, p.codpesq, p.descricaopesq, r.dtfinaliza, p.idpergunta, r.codfunc, r.codgrupo, g.descricao";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable RespostasSetor(int codSetor, int codfunc, int codpesq)
        {
            string sql = $@"select p.codpesq, p.descricaopesq, r.codgrupo, g.descricao descgrupo,
                            r.codfunc,
                            (select nome from fstpesqrh where codigo = r.codfunc) funcionario,
                            TO_DATE(r.dtfinaliza, 'DD/MM/YYYY') dtresposta,
                            p.idpergunta

                            from fstpesquisarh p, fstperguntarh pp, 
                            fstrespostasrh r , fstgruporh g

                            where p.codsetor = {codSetor}
                            and r.codfunc = {codfunc}
                            and p.idpergunta = pp.id 
                            and pp.idpergunta = r.idpergunta 
                            and r.codgrupo = g.codgrupo
                            and r.dtfinaliza is not null";

            if (codpesq != 0)
                sql += $" and p.codpesq = {codpesq} ";

            sql += " group by r.codfunc, p.codpesq, p.descricaopesq, r.dtfinaliza, p.idpergunta, r.codfunc, r.codgrupo, g.descricao";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
