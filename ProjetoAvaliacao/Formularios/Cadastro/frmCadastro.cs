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

namespace ProjetoAvaliacao.Formularios.Cadastro
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmPesquisa pesquisa = new frmPesquisa();
            pesquisa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroAvaliacao cadastroAvaliacao = new frmCadastroAvaliacao();
            cadastroAvaliacao.ShowDialog();
        }
    }
}
