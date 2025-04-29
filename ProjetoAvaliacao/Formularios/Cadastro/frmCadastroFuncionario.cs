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
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            CarregaTabela();
        }

        private void CarregaTabela()
        {
            dataGridView1.DataSource = FuncionarioDAO.Funcionarios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmExcel excel = new frmExcel();
            excel.ShowDialog();

            CarregaTabela();
        }
    }
}
