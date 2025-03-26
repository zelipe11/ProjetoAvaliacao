using ProjetoAvaliacao.DAO;
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
            if (comboBox1.Text == "Grupo Especifico")
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

                        DateTime dataInicio = dateTimePicker1.Value;
                        DateTime dataFim = dateTimePicker2.Value;


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

                DateTime dataInicio = dateTimePicker1.Value;
                DateTime dataFim = dateTimePicker2.Value;

                PesquisaDAO.InserirPesquisa(idPesquisa, pesquisa, tipoPesq, tipoAvalia, formato, dataInicio, dataFim, 0, IdPergunta);

                frmCadastrarPergunta cadastrarPergunta = new frmCadastrarPergunta(IdPergunta);
                cadastrarPergunta.ShowDialog();
                
            }
            this.Close();
        }
    }
}
