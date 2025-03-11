using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.Formularios.Analise
{
    public partial class frmCriarSenha : Form
    {
        string Cpf;
        public frmCriarSenha(string cpf)
        {
            InitializeComponent();

            this.Cpf = cpf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                string senha = textBox1.Text;
            }
            else
                MessageBox.Show("Os dois campos estão diferentes");
        }
    }
}
