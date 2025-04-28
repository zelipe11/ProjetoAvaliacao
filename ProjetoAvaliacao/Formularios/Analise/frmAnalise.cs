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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoAvaliacao.Formularios.Analise
{
    public partial class frmAnalise : Form
    {
        public int CodSetor = 0;
        public string Cpf;
        public int CodGestor;

        bool Finalizados = false;

        public frmAnalise(string cpf)
        {
            InitializeComponent();
            this.Cpf = cpf;
            CodSetor = InformacaoDAO.SetorDoUsuario(cpf);
            CodGestor = InformacaoDAO.CodigoDoUsuario(cpf);

            DataTable combo = InformacaoDAO.Funcionarios(CodGestor);
            DataRow newRow = combo.NewRow();
            newRow["nome"] = "Todos";
            newRow["codigo"] = 0;
            combo.Rows.InsertAt(newRow, 0);

            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "codigo";

            CarregaTabela();
        }

        private void CarregaTabela()
        {
            dataGridView1.DataSource = AnaliseDAO.RespostasSetor(CodGestor);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPerg = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDPERGUNTA"].Value);
            int codFun = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CODFUNC"].Value);
            int codGrupo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CODGRUPO"].Value);
            string nomeFunc = dataGridView1.Rows[e.RowIndex].Cells["FUNCIONARIO"].Value.ToString();

            frmAnaliseResposta analiseResposta = new frmAnaliseResposta(idPerg, codFun, codGrupo, nomeFunc);
            analiseResposta.ShowDialog();

            CarregaTabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codPesq = int.TryParse(textBox1.Text, out int result) ? result : 0;
            int codFunc = Convert.ToInt32(comboBox1.SelectedValue);
            Finalizados = checkBox1.Checked;

            dataGridView1.DataSource = AnaliseDAO.RespostasSetor(CodGestor, codFunc, codPesq, Finalizados);
        }
    }
}
