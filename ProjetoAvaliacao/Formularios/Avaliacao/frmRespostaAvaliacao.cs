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

        private bool jaExecutado = false;
        public frmRespostaAvaliacao(int codgrupo, int codfunc, int avaliacao)
        {
            InitializeComponent();
            this.Codgrupo = codgrupo;
            this.Codfunc = codfunc;
            this.Avaliacao = avaliacao;

            DataTable nomeCargo = InformacaoDAO.FuncionariosNomeCargo(codfunc);
            label1.Text = nomeCargo.Rows[0][0].ToString() + " - " + nomeCargo.Rows[0][1].ToString();

            DataTable pergunta = AvaliacaoDAO.Perguntas(codgrupo);

            dataGridView1.DataSource = pergunta;

            DataGridViewTextBoxColumn colunaResposta = new DataGridViewTextBoxColumn
            {
                Name = "RESPOSTA",
                HeaderText = "Resposta"
            };
            dataGridView1.Columns.Add(colunaResposta);

            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }


        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (jaExecutado)
                return;

            jaExecutado = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string tipoPergunta = row.Cells["TIPOPERG"].Value.ToString();
                if (tipoPergunta == "N")
                {
                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                    comboBoxCell.Items.AddRange(ObterOpcoesComboBox());
                    comboBoxCell.Value = row.Cells["RESPOSTA"].Value;
                    row.Cells["RESPOSTA"] = comboBoxCell;
                }
                else
                {
                    DataGridViewTextBoxCell textBoxCell = new DataGridViewTextBoxCell();
                    textBoxCell.Value = row.Cells["RESPOSTA"].Value;
                    row.Cells["RESPOSTA"] = textBoxCell;
                }
            }            
        }

        private string[] ObterOpcoesComboBox()
        {
            return new string[] { "0", "1", "2", "3", "4" };
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
                }
            }
            RespostaDAO.AvaliacaoFinalizada(Avaliacao);

            MessageBox.Show("Questionario respondido com sucesso");
            this.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                dataGridView1.BeginEdit(false);
                if (dataGridView1.EditingControl is ComboBox comboBox)
                {
                    comboBox.DroppedDown = true;
                }
            }
        }
    }
}
