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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoAvaliacao.Formularios.Avaliacao
{
    public partial class frmCadastroAvaliacao : Form
    {
        public frmCadastroAvaliacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAvaliacao = InformacaoDAO.SequencialAvaliacao();
            int codfunc = Convert.ToInt32(textBox1.Text);
            int idPergunta = Convert.ToInt32(textBox2.Text);

            MessageBox.Show("Avaliação adicionado com sucesso");
        }
    }
}
