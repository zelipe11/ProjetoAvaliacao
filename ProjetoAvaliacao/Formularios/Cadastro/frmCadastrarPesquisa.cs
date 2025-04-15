using ProjetoAvaliacao.DAO;
using ProjetoAvaliacao.Formularios.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.Formularios
{
    public partial class frmCadastrarPesquisa : Form
    {
        public int IdPergunta = 0;
        public frmCadastrarPesquisa()
        {
            InitializeComponent();

            DataTable combo = InformacaoDAO.TipoAvaliacao();
            comboBox2.DataSource = combo;
            comboBox2.DisplayMember = "descricao";
            comboBox2.ValueMember = "codavali";

            IdPergunta = PerguntaDAO.ValorPergunta();
            textBox2.Text = IdPergunta.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                int idPesquisa = InformacaoDAO.SequencialPesquisa();
                int tipoAvalia = Convert.ToInt32(comboBox2.SelectedValue);
                string pesquisa = textBox1.Text;
                string formato = "E";
                string tipoAvaliacao = comboBox2.Text;

                PesquisaDAO.InserirPesquisa(idPesquisa, pesquisa, null, tipoAvalia, formato, null, null, 0, IdPergunta);

                frmCadastrarPergunta cadastrarPergunta = new frmCadastrarPergunta(IdPergunta);
                cadastrarPergunta.ShowDialog();
            }

            else if (comboBox1.Text == "Grupo Especifico")
            {
                frmGrupo grupo = new frmGrupo();
                if (grupo.ShowDialog() == DialogResult.OK)
                {
                    List<int> dados = grupo.ListaGrupos;

                    foreach (int dado in dados)
                    {
                        int idPesquisa = InformacaoDAO.SequencialPesquisa();
                        string tipoPesq = comboBox1.Text;
                        int tipoAvalia = Convert.ToInt32(comboBox2.SelectedValue);
                        string pesquisa = textBox1.Text;
                        string formato = "I";
                        string tipoAvaliacao = comboBox2.Text;

                        string dataInicio = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                        string dataFim = dateTimePicker2.Value.ToString("dd/MM/yyyy");


                        PesquisaDAO.InserirPesquisa(idPesquisa, pesquisa, tipoPesq, tipoAvalia, formato, dataInicio, dataFim, dado, IdPergunta);

                        frmCadastrarPergunta cadastrarPergunta = new frmCadastrarPergunta(IdPergunta);
                        cadastrarPergunta.ShowDialog();
                        
                    }
                }
            }
            else if (comboBox1.Text == "Toda Empresa")
            {
                int idPesquisa = InformacaoDAO.SequencialPesquisa();
                string tipoPesq = comboBox1.Text;
                int tipoAvalia = Convert.ToInt32(comboBox2.SelectedValue);
                string pesquisa = textBox1.Text;
                string formato = "I";

                if (radioButton1.Checked)
                    formato = "A";
                else if (radioButton2.Checked)
                    formato = "I";

                string dataInicio = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                string dataFim = dateTimePicker2.Value.ToString("dd/MM/yyyy");

                PesquisaDAO.InserirPesquisa(idPesquisa, pesquisa, tipoPesq, tipoAvalia, formato, dataInicio, dataFim, 0, IdPergunta);

                frmCadastrarPergunta cadastrarPergunta = new frmCadastrarPergunta(IdPergunta);
                cadastrarPergunta.ShowDialog();
                
            }
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboBox1.Visible = false;
                label2.Visible = false;
                label7.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label6.Visible = false;
            }
            else if (radioButton1.Checked ||  radioButton2.Checked)
            {
                comboBox1.Visible = true;
                label2.Visible = true;
                label7.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                label6.Visible = true;
            }
        }
    }
}
