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
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Arquivos do Excel|*.xls;*.xlsx;*.xlsm;*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;

            if (!string.IsNullOrEmpty(filePath))
            {
                FuncionarioDAO.SalvarExcel(filePath);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


            else
            {
                MessageBox.Show("Por favor, selecione um arquivo Excel para salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
