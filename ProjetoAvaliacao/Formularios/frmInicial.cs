using FuncoesWinthor;
using ProjetoAvaliacao.Formularios;
using ProjetoAvaliacao.Formularios.Analise;
using ProjetoAvaliacao.Formularios.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo(@"\\10.10.10.15\ProjetosTI\Resposta Avaliacao\ProjetoRespostaAvaliacao.exe");
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPesquisaGestor pesquisa = new frmPesquisaGestor();
            pesquisa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario cadastroFuncionario = new frmCadastroFuncionario();
            cadastroFuncionario.ShowDialog();
        }
    }
}
