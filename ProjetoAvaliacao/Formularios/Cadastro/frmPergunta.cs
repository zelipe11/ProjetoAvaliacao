using ProjetoAvaliacao.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.Formularios.Cadastro
{
    public partial class frmPergunta : Form
    {
        public int Id = 0;

        public frmPergunta(int id)
        {
            InitializeComponent();
            this.Id = id;

            GerarTabela();
        }

        public void GerarTabela()
        {
            dataGridView1.DataSource = PerguntaDAO.PerguntasDaPesquisa(Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastrarPergunta cadastrarPergunta = new frmCadastrarPergunta(Id);
            cadastrarPergunta.ShowDialog();

            GerarTabela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idPergunta = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IDPERGUNTA"].Value);

                PerguntaDAO.ExcluirPergunta(idPergunta);
            }

            GerarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {           
            int idPergunta = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDPERGUNTA"].Value);

            frmEditarPergunta editarPergunta = new frmEditarPergunta(idPergunta);
            editarPergunta.ShowDialog();

            GerarTabela();
        }
    }
}
