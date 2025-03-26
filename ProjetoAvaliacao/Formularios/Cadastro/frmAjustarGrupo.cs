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
    public partial class frmAjustarGrupo : Form
    {
        int IdPesq = 0;
        string Pesq;

        public frmAjustarGrupo(int idPesq, string pesq)
        {
            this.IdPesq = idPesq;
            this.Pesq = pesq;           

            InitializeComponent();

            textBox1.Text = Pesq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tpPesq = textBox1.Text;
            GrupoDAO.AtualizarTipoPesq(IdPesq, tpPesq);
            MessageBox.Show("Alterado com sucesso!");
            this.Close();
        }
    }
}
