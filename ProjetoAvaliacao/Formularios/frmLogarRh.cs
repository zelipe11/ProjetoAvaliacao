using ProjetoAvaliacao.DAO;
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

namespace ProjetoAvaliacao.Formularios
{
    public partial class frmLogarRh : Form
    {
        public frmLogarRh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = textBox1.Text;
            string senha = textBox2.Text;
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (InformacaoDAO.ExisteCPFRH(cpf, senha))
            {
                frmCadastro cadastrar = new frmCadastro();
                cadastrar.ShowDialog();
            }

            else if (!InformacaoDAO.ExisteCPFRH(cpf, senha))
            {
                if (InformacaoDAO.TemCpfRh(cpf))
                {
                    if (!InformacaoDAO.TemSenha(cpf))
                    {
                        frmCriarSenha criarSenha = new frmCriarSenha(cpf);
                        criarSenha.ShowDialog();
                    }
                    else
                        MessageBox.Show("Senha Invalida!");
                }
                else
                    MessageBox.Show("CPF não cadastrado ou não tem permissão para acesso");
            }

            else
            {
                MessageBox.Show("CPF não cadastrado ou não tem permissão para acesso");
            }
        }
    }
}
