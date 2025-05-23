﻿using ProjetoAvaliacao.DAO;
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
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();

            GerarTabela();
        }

        public void GerarTabela()
        {
            dataGridView1.DataSource = PesquisaDAO.TabelaPesquisa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastrarPesquisa cadastrarPesquisa = new frmCadastrarPesquisa();
            cadastrarPesquisa.ShowDialog();

            GerarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDPERGUNTA"].Value);

            frmPergunta pergunta = new frmPergunta(id);
            pergunta.ShowDialog();

            GerarTabela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idPesquisa = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CODPESQ"].Value);

                PerguntaDAO.ExcluirPesquisa(idPesquisa);
            }

            GerarTabela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idPesquisa = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CODPESQ"].Value);

                DateTime dtInicio = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DTINICIO"].Value);
                DateTime dtFim = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DTFIM"].Value);

                frmEditarPeriodo editarPeriodo = new frmEditarPeriodo(idPesquisa, dtInicio, dtFim);
                editarPeriodo.ShowDialog();
            }

            GerarTabela();
        }
    }
}
