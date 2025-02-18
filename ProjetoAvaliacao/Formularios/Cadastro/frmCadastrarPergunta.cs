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
    public partial class frmCadastrarPergunta : Form
    {
        int IdPergunta;
        public frmCadastrarPergunta()
        {
            InitializeComponent();

            DataTable combo = InformacaoDAO.PegarGrupos();
            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "codgrupo";

            IdPergunta = PerguntaDAO.ValorPergunta();

            textBox2.Text = IdPergunta.ToString();
        }

        private void btnAdicionarPergunta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPergunta.Text))
            {
                int codGrupo = Convert.ToInt32(comboBox1.SelectedValue);
                string tipoPergunta = "";

                if (radioButton1.Checked)
                    tipoPergunta = "N";

                else if (radioButton2.Checked)
                    tipoPergunta = "T";


                dataGridView1.Rows.Add(txtPergunta.Text, codGrupo, tipoPergunta);

                txtPergunta.Clear();
                txtPergunta.Focus();
            }
            else
            {
                MessageBox.Show("Digite um texto antes de adicionar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string descricaoperg = textBox1.Text;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string pergunta = row.Cells[0].Value.ToString();
                    int codGrupo = Convert.ToInt32(row.Cells[1].Value.ToString());
                    int tipoPesq = Convert.ToInt32(row.Cells[2].Value.ToString());
                    string tipoPergunta = row.Cells[3].Value.ToString();

                    //Adicionar Pergunta no grupo
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastrarGrupo cadastrarGrupo = new frmCadastrarGrupo();
            cadastrarGrupo.ShowDialog();

            DataTable combo = InformacaoDAO.PegarGrupos();
            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "codgrupo";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int codGrupo = Convert.ToInt32(comboBox1.SelectedValue);

            DataTable combo = InformacaoDAO.PegarTipoPesqGrupo(codGrupo);
            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "codpesq";
        }
    }
}
