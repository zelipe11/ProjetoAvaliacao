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
        public int IdPergunta = 1;
        
        public frmCadastrarPergunta(int idPergunta)
        {
            InitializeComponent();

            this.IdPergunta = idPergunta;

            DataTable combo = InformacaoDAO.PegarGrupos();
            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "codgrupo";            

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

                int tipoPesq = Convert.ToInt32(comboBox2.SelectedValue);


                dataGridView1.Rows.Add(txtPergunta.Text, codGrupo, tipoPesq,tipoPergunta);

                txtPergunta.Clear();
                txtPergunta.Focus();

                comboBox1.Visible = false;
                textBox1.Visible = false;
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

                    PerguntaDAO.AdicionarPerguntas(IdPergunta, descricaoperg, codGrupo, tipoPesq, tipoPergunta, pergunta);                    
                }
                dataGridView1.Rows.Clear();
                MessageBox.Show("Grupo criado com sucesso!");
                this.Close();
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
            if (int.TryParse(comboBox1.SelectedValue?.ToString(), out int codGrupo))
            {
                DataTable combo = InformacaoDAO.PegarTipoPesqGrupo(codGrupo);

                comboBox2.DataSource = combo;
                comboBox2.DisplayMember = "descricao";
                comboBox2.ValueMember = "codpesq";
            }
        }
    }
}
