using ProjetoAvaliacao.DAO;
using ProjetoAvaliacao.Formularios.Avaliacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.Formularios.Analise
{
    public partial class frmAvaliacaoGrupo : Form
    {
        public int IdPesquisa = 0;
        public int Codfunc = 0;
        public string Cpf;
        int Avaliacao = 0;
        public frmAvaliacaoGrupo(string cpf, int idPesquisa, int codfunc, int avaliacao)
        {
            InitializeComponent();
            this.IdPesquisa = idPesquisa;
            this.Cpf = cpf;
            this.Codfunc = codfunc;
            this.Avaliacao = avaliacao;
            dataGridView2.DataSource = AvaliacaoDAO.Grupos(IdPesquisa);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int grupo = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["CODGRUPO"].Value);

                frmRespostaAvaliacao respostaAvaliacao = new frmRespostaAvaliacao(grupo, Codfunc, Avaliacao);
                respostaAvaliacao.ShowDialog();

                this.Close();
            }
        }
    }
}
