﻿namespace ProjetoAvaliacao.Formularios.Analise
{
    partial class frmAnalise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDCAMPANHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAMPANHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTRESPOSTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCAMPANHA,
            this.CAMPANHA,
            this.FUNCIONARIO,
            this.DTRESPOSTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(567, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // IDCAMPANHA
            // 
            this.IDCAMPANHA.HeaderText = "Id Campanha";
            this.IDCAMPANHA.Name = "IDCAMPANHA";
            this.IDCAMPANHA.ReadOnly = true;
            // 
            // CAMPANHA
            // 
            this.CAMPANHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAMPANHA.HeaderText = "Campanha";
            this.CAMPANHA.Name = "CAMPANHA";
            this.CAMPANHA.ReadOnly = true;
            // 
            // FUNCIONARIO
            // 
            this.FUNCIONARIO.HeaderText = "Funcionario";
            this.FUNCIONARIO.Name = "FUNCIONARIO";
            this.FUNCIONARIO.ReadOnly = true;
            // 
            // DTRESPOSTA
            // 
            this.DTRESPOSTA.HeaderText = "Data Resposta";
            this.DTRESPOSTA.Name = "DTRESPOSTA";
            this.DTRESPOSTA.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Campanha:";
            // 
            // frmAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAnalise";
            this.Text = "Analise de Respostas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTRESPOSTA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}