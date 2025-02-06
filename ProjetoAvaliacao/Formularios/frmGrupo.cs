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
        public List<string> ListaGrupos;
        public frmGrupo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    ListaGrupos.Add(row.Cells[0].Value.ToString());
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
