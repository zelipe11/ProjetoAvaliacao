namespace ProjetoAvaliacao.Formularios.Cadastro
{
    partial class frmPergunta
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
            this.button2 = new System.Windows.Forms.Button();
            this.DESCRICAOPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPPERG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORMATOPESQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            this.DESCRICAOPESQ,
            this.CODGRUPO,
            this.GRUPO,
            this.TPPERG,
            this.FORMATOPESQ,
            this.PERGUNTA,
            this.IDPERGUNTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(12, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DESCRICAOPESQ
            // 
            this.DESCRICAOPESQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRICAOPESQ.DataPropertyName = "DESCRICAOPESQ";
            this.DESCRICAOPESQ.HeaderText = "Descrição";
            this.DESCRICAOPESQ.Name = "DESCRICAOPESQ";
            this.DESCRICAOPESQ.ReadOnly = true;
            // 
            // CODGRUPO
            // 
            this.CODGRUPO.DataPropertyName = "CODGRUPO";
            this.CODGRUPO.HeaderText = "codgrupo";
            this.CODGRUPO.Name = "CODGRUPO";
            this.CODGRUPO.ReadOnly = true;
            this.CODGRUPO.Visible = false;
            // 
            // GRUPO
            // 
            this.GRUPO.DataPropertyName = "GRUPO";
            this.GRUPO.HeaderText = "Grupo";
            this.GRUPO.Name = "GRUPO";
            this.GRUPO.ReadOnly = true;
            // 
            // TPPERG
            // 
            this.TPPERG.DataPropertyName = "TPPESQ";
            this.TPPERG.HeaderText = "Tipo Pesquisa";
            this.TPPERG.Name = "TPPERG";
            this.TPPERG.ReadOnly = true;
            // 
            // FORMATOPESQ
            // 
            this.FORMATOPESQ.DataPropertyName = "FORMATOPESQ";
            this.FORMATOPESQ.HeaderText = "Tipo Pergunta";
            this.FORMATOPESQ.Name = "FORMATOPESQ";
            this.FORMATOPESQ.ReadOnly = true;
            // 
            // PERGUNTA
            // 
            this.PERGUNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PERGUNTA.DataPropertyName = "PERGUNTA";
            this.PERGUNTA.HeaderText = "Pergunta";
            this.PERGUNTA.Name = "PERGUNTA";
            this.PERGUNTA.ReadOnly = true;
            // 
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "idpergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.ReadOnly = true;
            this.IDPERGUNTA.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPergunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perguntas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAOPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPPERG;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORMATOPESQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERGUNTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
        private System.Windows.Forms.Button button1;
    }
}