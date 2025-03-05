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

        public frmAnaliseResposta(int codPergunta, int coduser, int codgrupo, string nomeFunc)
        {
            InitializeComponent();
            this.CodPergunta = codPergunta;
            this.CodUser = coduser;
            this.CodGrupo = codgrupo;
            label1.Text = nomeFunc;

            DataTable resposta = RespostaDAO.RespostasFunc(CodPergunta, CodUser, CodGrupo);

            if (resposta.Rows[0]["OBSERVACAO"].ToString() != string.Empty)
            {
                int columnIndex = dataGridView1.Columns["NOTARESP"].Index;

                dataGridView1.Columns.RemoveAt(columnIndex);

                DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn
                {
                    Name = "NOTARESP",
                    HeaderText = "Resposta Gestor",
                    DataPropertyName = "RESPOSTAGESTOR"
                };

                button1.Enabled = false;
                dataGridView1.Columns.Insert(columnIndex, coluna);
                dataGridView1.DataSource = resposta;
            }
            else
            {
                dataGridView1.DataSource = resposta;
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
                    int id = Convert.ToInt32(row.Cells["CODPERG"].Value);
                    int idperg = Convert.ToInt32(row.Cells["IDPERGUNTA"].Value);
                    int respostaFunc = Convert.ToInt32(row.Cells["RESPOSTA"].Value.ToString());
                    string observacaoGestor = row.Cells["OBSERVACAO"].Value.ToString();
                    string acaoGestor = row.Cells["ACAOGESTOR"].Value.ToString();
                    DateTime dataprazo = DateTime.Now.AddDays(Convert.ToDouble(row.Cells["DTPRAZO"].Value));

                    RespostaDAO.RespostasAnaliseGestor(CodGrupo, CodUser, id, respostaFunc, observacaoGestor, acaoGestor, idperg, dataprazo);
                }
            }
            MessageBox.Show("Questionario respondido com sucesso");
            this.Close();
        }
    }
}
