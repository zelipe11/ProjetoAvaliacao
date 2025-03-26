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

namespace ProjetoAvaliacao
{
    public partial class frmPesquisaGestor : Form
    {
        public frmPesquisaGestor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogar login = new frmLogar("ANALISE");
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogar login = new frmLogar("AVALIACAO");
            login.ShowDialog();
        }
    }
}
