﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao.Formularios.Analise
{
    public partial class frmAnalise : Form
    {
        public frmAnalise()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCampanha = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            frmAnaliseResposta analiseResposta = new frmAnaliseResposta();
            analiseResposta.ShowDialog();
        }
    }
}
