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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoAvaliacao.Formularios.Avaliacao
{
    public partial class frmCadastroAvaliacao : Form
    {
        public frmCadastroAvaliacao()
        {
            InitializeComponent();

            DataTable dt = AvaliacaoDAO.PeriodosAvalia();

            textBox1.Text = dt.Rows[0][0].ToString();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            textBox4.Text = dt.Rows[0][3].ToString();
            textBox5.Text = dt.Rows[0][4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int periodo1 = Convert.ToInt32(textBox1.Text);
            int periodo2 = Convert.ToInt32(textBox2.Text);
            int periodo3 = Convert.ToInt32(textBox3.Text);
            int periodo4 = Convert.ToInt32(textBox4.Text);
            int periodo5 = Convert.ToInt32(textBox5.Text);

            bool alterado = AvaliacaoDAO.AdicionarPeriodo(periodo1, periodo2, periodo3, periodo4 , periodo5);

            if (alterado)
                MessageBox.Show("Periodo adicionado com sucesso");
            else
                MessageBox.Show("Falha ao adicionar periodo");
        }
    }
}
