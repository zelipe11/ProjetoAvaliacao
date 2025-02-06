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

namespace ProjetoAvaliacao.Formularios
{
    public partial class frmGrupo : Form
    {
        public List<int> ListaGrupos;
        public frmGrupo()
        {
            InitializeComponent();

            DataTable combo = InformacaoDAO.PegarSetores();
            comboBox1.DataSource = combo;
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "codsetor";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    ListaGrupos.Add(Convert.ToInt32(row.Cells[1].Value));
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codSetor = Convert.ToInt32(comboBox1.SelectedValue);
            string setor = comboBox1.Text;

            dataGridView1.Rows.Add(codSetor, setor);
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
