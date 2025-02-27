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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAvaliacao = InformacaoDAO.SequencialAvaliacao();
            int codfunc = Convert.ToInt32(textBox1.Text);
            int idPergunta = Convert.ToInt32(textBox2.Text);

            DateTime dataInicio = dateTimePicker1.Value;
            DateTime dataFim = dateTimePicker2.Value;


            PesquisaDAO.InserirAvaliacao(idAvaliacao, codfunc, dataInicio, dataFim, idPergunta);
            MessageBox.Show("Avaliação adicionado com sucesso");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = InformacaoDAO.FuncionariosNome(Convert.ToInt32(textBox1.Text));


                if (dt.Rows.Count > 0)
                {
                    textBox3.Text = dt.Rows[0]["nome"].ToString();
                }
                else
                {
                    textBox3.Text = "";
                }
            }
            catch
            {
                textBox3.Text = "";
            }
        }
    }
}
