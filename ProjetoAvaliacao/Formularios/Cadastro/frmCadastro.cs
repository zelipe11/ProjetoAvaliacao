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
            frmCadastrarCampanha cadastrarCampanha = new frmCadastrarCampanha();
            cadastrarCampanha.ShowDialog();
        }

        private void btnPergunta_Click(object sender, EventArgs e)
        {
            frmCadastrarPergunta cadastrarPergunta = new frmCadastrarPergunta();
            cadastrarPergunta.ShowDialog();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            frmCadastrarGrupo cadastrarGrupo = new frmCadastrarGrupo();
            cadastrarGrupo.ShowDialog();
        }
    }
}
