namespace ProjetoAvaliacao.Formularios.Cadastro
{
    partial class frmPesquisa
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
            this.button1 = new System.Windows.Forms.Button();
            this.CODPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAOPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVALIACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORMATOPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
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
            this.CODPESQ,
            this.DESCRICAOPESQ,
            this.TIPOPESQ,
            this.AVALIACAO,
            this.FORMATOPESQ,
            this.DTINICIO,
            this.DTFIM,
            this.SETOR,
            this.IDPERGUNTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CODPESQ
            // 
            this.CODPESQ.DataPropertyName = "CODPESQ";
            this.CODPESQ.HeaderText = "Id Pesquisa";
            this.CODPESQ.Name = "CODPESQ";
            this.CODPESQ.ReadOnly = true;
            // 
            // DESCRICAOPESQ
            // 
            this.DESCRICAOPESQ.DataPropertyName = "DESCRICAOPESQ";
            this.DESCRICAOPESQ.HeaderText = "Descrição";
            this.DESCRICAOPESQ.Name = "DESCRICAOPESQ";
            this.DESCRICAOPESQ.ReadOnly = true;
            this.DESCRICAOPESQ.Width = 73;
            // 
            // TIPOPESQ
            // 
            this.TIPOPESQ.DataPropertyName = "TIPOPESQ";
            this.TIPOPESQ.HeaderText = "Tipo Pesquisa";
            this.TIPOPESQ.Name = "TIPOPESQ";
            this.TIPOPESQ.ReadOnly = true;
            // 
            // AVALIACAO
            // 
            this.AVALIACAO.DataPropertyName = "AVALIACAO";
            this.AVALIACAO.HeaderText = "Avaliação";
            this.AVALIACAO.Name = "AVALIACAO";
            this.AVALIACAO.ReadOnly = true;
            // 
            // FORMATOPESQ
            // 
            this.FORMATOPESQ.DataPropertyName = "FORMATOPESQ";
            this.FORMATOPESQ.HeaderText = "Formato";
            this.FORMATOPESQ.Name = "FORMATOPESQ";
            this.FORMATOPESQ.ReadOnly = true;
            // 
            // DTINICIO
            // 
            this.DTINICIO.DataPropertyName = "DTINICIO";
            this.DTINICIO.HeaderText = "Dt Inicio";
            this.DTINICIO.Name = "DTINICIO";
            this.DTINICIO.ReadOnly = true;
            // 
            // DTFIM
            // 
            this.DTFIM.DataPropertyName = "DTFIM";
            this.DTFIM.HeaderText = "Dt Fim";
            this.DTFIM.Name = "DTFIM";
            this.DTFIM.ReadOnly = true;
            // 
            // SETOR
            // 
            this.SETOR.DataPropertyName = "SETOR";
            this.SETOR.HeaderText = "Setor";
            this.SETOR.Name = "SETOR";
            this.SETOR.ReadOnly = true;
            // 
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "idpergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.ReadOnly = true;
            this.IDPERGUNTA.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAOPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVALIACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORMATOPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTFIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
        private System.Windows.Forms.Button button2;
    }
}