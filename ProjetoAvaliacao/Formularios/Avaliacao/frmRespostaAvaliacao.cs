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

namespace ProjetoAvaliacao.Formularios.Avaliacao
{
    public partial class frmRespostaAvaliacao : Form
    {
        int Codgrupo = 0;
        int Codfunc = 0;
        int Avaliacao = 0;
        public frmRespostaAvaliacao(int codgrupo, int codfunc, int avaliacao)
        {
            InitializeComponent();
            this.Codgrupo = codgrupo;
            this.Codfunc = codfunc;
            this.Avaliacao = avaliacao;

            DataTable nomeCargo = InformacaoDAO.FuncionariosNomeCargo(codfunc);
            label1.Text = nomeCargo.Rows[0][0].ToString() + " - " + nomeCargo.Rows[0][1].ToString();

            DataTable pergunta = AvaliacaoDAO.Perguntas(codgrupo);

            if (pergunta.Rows[0]["RESPOSTA"].ToString() != string.Empty)
            {
                int columnIndex = dataGridView1.Columns["RESPOSTA"].Index;

                dataGridView1.Columns.RemoveAt(columnIndex);

                DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn
                {
                    Name = "RESPOSTA",
                    HeaderText = "Resposta",
                    DataPropertyName = "RESPOSTA"
                };

                button1.Enabled = false;
                dataGridView1.Columns.Insert(columnIndex, coluna);
                dataGridView1.DataSource = pergunta;
            }
            else
            {
                dataGridView1.DataSource = pergunta;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && (row.Cells["RESPOSTA"].Value == null || string.IsNullOrWhiteSpace(row.Cells["RESPOSTA"].Value.ToString())))
                {
                    MessageBox.Show("Todas as linhas devem ter as Respostas e Comentarios respondidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    int idperg = Convert.ToInt32(row.Cells["IDPERGUNTA"].Value);
                    int respostaFunc = Convert.ToInt32(row.Cells["RESPOSTA"].Value.ToString());


                    RespostaDAO.FinalizarRespostas(Codgrupo, Codfunc, id, respostaFunc, idperg);
                    RespostaDAO.AvaliacaoFinalizada(Avaliacao);
                }
            }
            MessageBox.Show("Questionario respondido com sucesso");
            this.Close();
        }
    }
}
