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
    public partial class frmCadastrarGrupo : Form
    {
        int CodigoGrupo = 1;
        public frmCadastrarGrupo()
        {
            InitializeComponent();

            DataTable combo = InformacaoDAO.PegarGrupos();
            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "codgrupo";

            CarregaTabela();
        }

        private void CarregaTabela()
        {
            dataGridView1.Rows.Clear();

            DataTable grupo = GrupoDAO.TabelaDePesquisa(CodigoGrupo);

            foreach (DataRow linhas in grupo.Rows)
            {
                object[] values = linhas.ItemArray;
                dataGridView1.Rows.Add(values);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string grupo = txtPergunta.Text;
            int codTipoPesq = Convert.ToInt32(comboBox1.SelectedValue);
            bool inserirGrupo = false;

            if (!string.IsNullOrEmpty(grupo))
                inserirGrupo = GrupoDAO.InserirTPPesq(grupo, codTipoPesq);

            if (inserirGrupo)
                MessageBox.Show("Grupo Inserido!");
            else
                MessageBox.Show("Não foi possivel inserir grupo");

            txtPergunta.Clear();

            CarregaTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idGrupo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string grup = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            frmAjustarGrupo ajustarGrupo = new frmAjustarGrupo(idGrupo, grup);
            ajustarGrupo.ShowDialog();

            CarregaTabela();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoGrupo = int.TryParse(comboBox1.SelectedValue?.ToString(), out int resultado) ? resultado : 1;
            CarregaTabela();
        }
    }
}
