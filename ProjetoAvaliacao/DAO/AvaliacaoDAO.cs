using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
