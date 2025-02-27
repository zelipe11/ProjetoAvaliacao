using FuncoesWinthor;
using ProjetoAvaliacao.Formularios;
using ProjetoAvaliacao.Formularios.Analise;
using ProjetoAvaliacao.Formularios.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastrar = new frmCadastro();
            cadastrar.ShowDialog();
        }

        private void btnAnalise_Click(object sender, EventArgs e)
        {
            frmLogar login = new frmLogar("ANALISE");
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogar login = new frmLogar("AVALIACAO");
            login.ShowDialog();
        }
    }
}
