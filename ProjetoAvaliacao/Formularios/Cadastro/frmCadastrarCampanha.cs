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
    public partial class frmCadastrarCampanha : Form
    {
        public frmCadastrarCampanha()
        {
            InitializeComponent();

            //Puxar grupos
            // DataTable combo = OcorrenciaDAO.PegarSetores();
            //comboBox1.DataSource = combo;
            //comboBox1.DisplayMember = "descricao";
            //comboBox1.ValueMember = "codsetor";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Grupo Especifico")
            {
                frmGrupo grupo = new frmGrupo();
                if (grupo.ShowDialog() == DialogResult.OK)
                {
                    List<int> dados = grupo.ListaGrupos;                    

                    foreach (int dado in dados)
                    {
                        //Pegar ID da campanha

                        string campanha = textBox1.Text;

                        string formato;

                        if (radioButton1.Checked)
                            formato = "A";

                        else if (radioButton2.Checked)
                            formato = "I";

                        string tipoAvaliacao = comboBox2.Text;

                        DateTime dataInicio = dateTimePicker1.Value;
                        DateTime dataFim = dateTimePicker2.Value;

                        int codGrupo = Convert.ToInt32(comboBox3.SelectedValue);

                        //Cadastrar Campanha

                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
