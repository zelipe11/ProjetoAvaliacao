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

            AdicionarColunaRespostaGestor();

            dataGridView1.DataSource = resposta;

            dataGridView1.DataError += DataGridView1_DataError;
        }

        private void AdicionarColunaRespostaGestor()
        {
            // Criar a coluna ComboBox
            DataGridViewComboBoxColumn colRespostaGestor = new DataGridViewComboBoxColumn
            {
                Name = "RESPOSTAGESTOR",
                HeaderText = "Resposta Gestor",
                DataPropertyName = "RESPOSTAGESTOR",
                FlatStyle = FlatStyle.Flat
            };

            for (int i = 0; i <= 5; i++)
            {
                colRespostaGestor.Items.Add(i.ToString());
            }

            dataGridView1.Columns.Add(colRespostaGestor);
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Tratar erros de validação do ComboBox
            if (e.Exception is ArgumentException &&
                dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                e.ThrowException = false;
                MessageBox.Show("Por favor, selecione um valor válido entre 0 e 5.", "Valor Inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void button1_Click(object sender, EventArgs e)
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
                    int respostaFunc = Convert.ToInt32(row.Cells["RESPOSTAGESTOR"].Value.ToString());
                    string observacaoGestor = row.Cells["OBSERVACAO"].Value.ToString().Trim();
                    string acaoGestor = row.Cells["ACAOGESTOR"].Value.ToString().Trim();
                    DateTime dataprazo = DateTime.Now.AddDays(Convert.ToDouble(row.Cells["DTPRAZO"].Value));

                    RespostaDAO.RespostasAnaliseGestor(CodGrupo, CodUser, id, respostaFunc, observacaoGestor, acaoGestor, idperg, dataprazo);
                }
            }
            MessageBox.Show("Questionario respondido com sucesso");
            this.Close();
        }
    }
}
