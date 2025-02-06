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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnAdicionarPergunta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPergunta.Text))
            {                
                dataGridView1.Rows.Add(txtPergunta.Text);

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
            if (comboBox1.Text == "Grupo Especifico")
            {
                frmGrupo grupo = new frmGrupo();
                if (grupo.ShowDialog() == DialogResult.OK)
                {
                    List<string> dados = grupo.ListaGrupos;                    

                    foreach (string dado in dados)
                    {
                        //Pegar ID da campanha

                        string campanha = textBox1.Text;

                        string formato;

                        if (radioButton1.Checked)
                            formato = "A";

                        else if (radioButton2.Checked)
                            formato = "I";

                        string tipoAvaliacao = comboBox2.Text;

                        DateTime dataInicio = dateTimePicker1.Value;
                        DateTime dataFim = dateTimePicker2.Value;

                        var perguntas = dataGridView1.Rows[0].Cells["PERGUNTAS"].Value as IEnumerable<string>;

                        if (perguntas != null)
                        {
                            foreach (var pergunta in perguntas)
                            {
                                //salvar perguntas  ( 1   Campanha    A   Auto Avaliação   Pergunta   SetorId )
                            }
                        }

                    }
                }
            }
        }
    }
}
