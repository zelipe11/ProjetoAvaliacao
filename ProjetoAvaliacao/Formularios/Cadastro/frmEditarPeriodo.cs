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
    public partial class frmEditarPeriodo : Form
    {

        public DateTime Dtinicio;
        public DateTime Dtfim;
        public int IdPesquisa;

        public frmEditarPeriodo(int idPesquisa, DateTime dtInicio, DateTime dtFim)
        {
            this.Dtinicio = dtInicio;
            this.Dtfim = dtFim;
            this.IdPesquisa = idPesquisa;
            InitializeComponent();

            dateTimePicker1.Value = dtInicio;
            dateTimePicker2.Value = dtFim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dtinicio = dateTimePicker1.Value;
            Dtfim = dateTimePicker2.Value;

            PesquisaDAO.AtualizarPesquisa(Dtinicio, Dtfim , IdPesquisa);

            MessageBox.Show("Periodo atualizado com sucesso");
            this.Close();
        }
    }
}
