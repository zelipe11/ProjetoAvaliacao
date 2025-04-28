using ProjetoAvaliacao.DAO;
using ProjetoAvaliacao.Formularios.Analise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.Formularios.Avaliacao
{
    public partial class frmAvaliacao : Form
    {
        string Cpf;
        public frmAvaliacao(string cpf)
        {
            InitializeComponent();
            this.Cpf = cpf;
            int codSetor = InformacaoDAO.CodigoDoUsuario(cpf);            
            dataGridView1.DataSource = AvaliacaoDAO.Avaliacoes(codSetor);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPergunta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDPERGUNTA"].Value);
                int codfunc = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CODFUNC"].Value);
                int avaliacao = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDAVALIACAO"].Value);

                frmAvaliacaoGrupo grupo = new frmAvaliacaoGrupo(Cpf, idPergunta, codfunc, avaliacao);
                grupo.ShowDialog();

                this.Close();
            }
        }
    }
}
