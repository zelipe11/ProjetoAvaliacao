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
    public partial class frmEditarPergunta : Form
    {
        public int Idpergunta = 0;
        public frmEditarPergunta(int idpergunta)
        {
            InitializeComponent();
            this.Idpergunta = idpergunta;

            DataTable pergunta = PerguntaDAO.Pergunta(idpergunta);

            textBox1.Text = pergunta.Rows[0][0].ToString();

            if (pergunta.Rows[0][1].ToString() == "N")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if (pergunta.Rows[0][1].ToString() == "T")
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pergunta = textBox1.Text;
            string tipoPerg = "";

            if (radioButton1.Checked)
                tipoPerg = "N";
            else if (radioButton2.Checked)
                tipoPerg = "T";

            PerguntaDAO.EditarPergunta(pergunta, tipoPerg, Idpergunta);
        }
    }
}
