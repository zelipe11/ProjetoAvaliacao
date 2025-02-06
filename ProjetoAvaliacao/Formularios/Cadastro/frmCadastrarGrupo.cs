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
    public partial class frmCadastrarGrupo : Form
    {
        public frmCadastrarGrupo()
        {
            InitializeComponent();

            CarregaTabela();
        }

        private void CarregaTabela()
        {
            //Puxar os grupos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string grupo = txtPergunta.Text;

            //Adicionar aos grupos

            txtPergunta.Clear();

            CarregaTabela();
        }
    }
}
