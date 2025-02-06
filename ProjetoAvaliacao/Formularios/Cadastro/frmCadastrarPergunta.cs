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
        public frmCadastrarPergunta()
        {
            InitializeComponent();

            //Puxar grupos
            // DataTable combo = OcorrenciaDAO.PegarSetores();
            //comboBox1.DataSource = combo;
            //comboBox1.DisplayMember = "descricao";
            //comboBox1.ValueMember = "codsetor";
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
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string pergunta = row.Cells[0].Value.ToString();
                    int codGrupo = Convert.ToInt32(row.Cells[1].Value);
                    string tipoPergunta = row.Cells[3].Value.ToString();

                    //Adicionar Pergunta no grupo
                }
            }
        }
    }
}
