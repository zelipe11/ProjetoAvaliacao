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
                            pr.nome funcionario,
                            TO_DATE(r.dtfinaliza, 'DD/MM/YYYY') dtresposta,
                            p.idpergunta

                            from fstpesquisarh p, fstperguntarh pp, 
                            fstrespostasrh r , fstgruporh g, fstpesqrh pr

                            where p.idpergunta = pp.id 
                            and pp.idpergunta = r.idpergunta
                            and r.codfunc = pr.codigo
                            and pr.codgestor = {codSetor}
                            and r.codgrupo not in (4)
                            and r.dtfinalizagestor is null
                            and r.codgrupo = g.codgrupo
                            and r.dtfinaliza is not null
                            group by r.codfunc, p.codpesq, p.descricaopesq, r.dtfinaliza, p.idpergunta, r.codfunc, r.codgrupo, g.descricao, pr.nome";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
        
        public static DataTable RespostasSetor(int codSetor, int codfunc, int codpesq, bool finalizadas)
        {
            string sql = $@"select p.codpesq, p.descricaopesq, r.codgrupo, g.descricao descgrupo,
                            r.codfunc,
                            pr.nome funcionario,
                            TO_DATE(r.dtfinaliza, 'DD/MM/YYYY') dtresposta,
                            p.idpergunta

                            from fstpesquisarh p, fstperguntarh pp, 
                            fstrespostasrh r , fstgruporh g, fstpesqrh pr

                            where p.idpergunta = pp.id 
                            and pp.idpergunta = r.idpergunta 
                            and r.codfunc = pr.codigo
                            and pr.codgestor = {codSetor}
                            and r.codgrupo not in (4)                            
                            and r.codgrupo = g.codgrupo
                            and r.dtfinaliza is not null ";

            if (finalizadas)
                sql += " and r.dtfinalizagestor is not null ";
            else
                sql += " and r.dtfinalizagestor is null ";

            if (codpesq != 0)
                sql += $" and p.codpesq = {codpesq} ";

            if (codfunc != 0)
                sql += $" and r.codfunc = {codfunc} ";

            sql += " group by r.codfunc, p.codpesq, p.descricaopesq, r.dtfinaliza, p.idpergunta, r.codfunc, r.codgrupo, g.descricao, pr.nome";

            return MetodosDB.ExecutaSelect(sql, "FESTPAN");
        }
    }
}
