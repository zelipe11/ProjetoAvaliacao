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

namespace ProjetoAvaliacao.Formularios.Analise
{
    public partial class frmAnaliseResposta : Form
    {
        public int CodPergunta = 0;
        public int CodUser = 0;
        public int CodGrupo = 0;

        private bool jaExecutado = false;

        public frmAnaliseResposta(int codPergunta, int coduser, int codgrupo, string nomeFunc)
        {
            InitializeComponent();
            this.CodPergunta = codPergunta;
            this.CodUser = coduser;
            this.CodGrupo = codgrupo;
            label1.Text = nomeFunc;

            DataTable resposta = RespostaDAO.RespostasFunc(CodPergunta, CodUser, CodGrupo);

            dataGridView1.DataSource = resposta;

            DataGridViewTextBoxColumn colunaResposta = new DataGridViewTextBoxColumn
            {
                Name = "RESPOSTAGESTOR",
                HeaderText = "Resposta Gestor"
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
                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                comboBoxCell.Items.AddRange(ObterOpcoesComboBox());
                comboBoxCell.Value = row.Cells["RESPOSTAGESTOR"].Value;
                row.Cells["RESPOSTAGESTOR"] = comboBoxCell;

            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["CODPERG"].Value != DBNull.Value)
                {
                    int id = Convert.ToInt32(row.Cells["CODPERG"].Value);
                    int idPerg = Convert.ToInt32(row.Cells["IDPERGUNTA"].Value);

                    if (RespostaDAO.ExisteRespostaSalva(CodGrupo, CodUser, id, idPerg))
                    {
                        DataTable resposta = RespostaDAO.RespostasSalvas(id, CodGrupo, CodUser, idPerg);

                        if (resposta.Rows.Count > 0)
                        {
                            row.Cells["RESPOSTAGESTOR"].Value = resposta.Rows[0][0] != DBNull.Value ? resposta.Rows[0][0].ToString() : string.Empty;
                        }

                    }

                    if (RespostaDAO.ExisteRespostaFinalizada(CodGrupo, CodUser, id, idPerg))
                    {
                        button1.Enabled = false;
                        button2.Enabled = false;
                    }
                }
            }
        }

        private string[] ObterOpcoesComboBox()
        {
            return new string[] { "0", "1", "2", "3", "4", "5" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["RESPOSTAGESTOR"].Value != null)
                {
                    int id = Convert.ToInt32(row.Cells["CODPERG"].Value);
                    int idperg = Convert.ToInt32(row.Cells["IDPERGUNTA"].Value);
                    int? respostaFunc = string.IsNullOrWhiteSpace(row.Cells["RESPOSTAGESTOR"].Value?.ToString()) ? (int?)null : Convert.ToInt32(row.Cells["RESPOSTAGESTOR"].Value);
                    string observacaoGestor = row.Cells["OBSERVACAO"].Value.ToString().Trim();
                    string acaoGestor = row.Cells["ACAOGESTOR"].Value.ToString().Trim();
                    DateTime? dataprazo = string.IsNullOrWhiteSpace(row.Cells["DTPRAZO"].Value?.ToString()) ? (DateTime?)null : Convert.ToDateTime(row.Cells["DTPRAZO"].Value);

                    RespostaDAO.RespostasSalvasAnaliseGestor(CodGrupo, CodUser, id, respostaFunc, observacaoGestor, acaoGestor, idperg, dataprazo);
                }
            }
            MessageBox.Show("Respostas Salvas com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && (row.Cells["RESPOSTAGESTOR"].Value == null || string.IsNullOrWhiteSpace(row.Cells["RESPOSTAGESTOR"].Value.ToString())))
                {
                    MessageBox.Show("Todas as linhas devem ter as Respostas e Comentarios respondidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    int id = Convert.ToInt32(row.Cells["CODPERG"].Value);
                    int idperg = Convert.ToInt32(row.Cells["IDPERGUNTA"].Value);
                    int? respostaFunc = string.IsNullOrWhiteSpace(row.Cells["RESPOSTAGESTOR"].Value?.ToString()) ? (int?)null : Convert.ToInt32(row.Cells["RESPOSTAGESTOR"].Value);
                    string observacaoGestor = row.Cells["OBSERVACAO"].Value.ToString().Trim();
                    string acaoGestor = row.Cells["ACAOGESTOR"].Value.ToString().Trim();
                    DateTime? dataprazo = string.IsNullOrWhiteSpace(row.Cells["DTPRAZO"].Value?.ToString()) ? (DateTime?)null : Convert.ToDateTime(row.Cells["DTPRAZO"].Value);

                    RespostaDAO.RespostasFinalizaAnaliseGestor(CodGrupo, CodUser, id, respostaFunc, observacaoGestor, acaoGestor, idperg, dataprazo);
                }
            }
            MessageBox.Show("Questionario finalizado com sucesso!");
            this.Close();
        }
    }
}
