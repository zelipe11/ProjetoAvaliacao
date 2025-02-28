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
        public frmCadastrarGrupo()
        {
            InitializeComponent();

            DataTable combo = InformacaoDAO.PegarTipoPesq();
            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "codpesq";

            CarregaTabela();
        }

        private void CarregaTabela()
        {
            dataGridView1.Rows.Clear();

            DataTable grupo = GrupoDAO.TabelaDeGrupos();

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
                inserirGrupo = GrupoDAO.InserirGrupo(grupo, codTipoPesq);

            if (inserirGrupo)
                MessageBox.Show("Grupo Inserido!");
            else
                MessageBox.Show("Não foi possivel inserir grupo");

            txtPergunta.Clear();

            CarregaTabela();
        }
    }
}
