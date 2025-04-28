namespace ProjetoAvaliacao.Formularios.Analise
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
            this.CODGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODFUNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTRESPOSTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.CODGRUPO,
            this.DESCGRUPO,
            this.CODFUNC,
            this.FUNCIONARIO,
            this.DTRESPOSTA,
            this.IDPERGUNTA});
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
            this.IDCAMPANHA.DataPropertyName = "CODPESQ";
            this.IDCAMPANHA.HeaderText = "Id Pesquisa";
            this.IDCAMPANHA.Name = "IDCAMPANHA";
            this.IDCAMPANHA.ReadOnly = true;
            // 
            // CAMPANHA
            // 
            this.CAMPANHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAMPANHA.DataPropertyName = "DESCRICAOPESQ";
            this.CAMPANHA.HeaderText = "Pesquisa";
            this.CAMPANHA.Name = "CAMPANHA";
            this.CAMPANHA.ReadOnly = true;
            // 
            // CODGRUPO
            // 
            this.CODGRUPO.DataPropertyName = "CODGRUPO";
            this.CODGRUPO.HeaderText = "Codgrupo";
            this.CODGRUPO.Name = "CODGRUPO";
            this.CODGRUPO.ReadOnly = true;
            this.CODGRUPO.Visible = false;
            // 
            // DESCGRUPO
            // 
            this.DESCGRUPO.DataPropertyName = "DESCGRUPO";
            this.DESCGRUPO.HeaderText = "Grupo";
            this.DESCGRUPO.Name = "DESCGRUPO";
            this.DESCGRUPO.ReadOnly = true;
            // 
            // CODFUNC
            // 
            this.CODFUNC.DataPropertyName = "CODFUNC";
            this.CODFUNC.HeaderText = "Codfunc";
            this.CODFUNC.Name = "CODFUNC";
            this.CODFUNC.ReadOnly = true;
            this.CODFUNC.Visible = false;
            // 
            // FUNCIONARIO
            // 
            this.FUNCIONARIO.DataPropertyName = "FUNCIONARIO";
            this.FUNCIONARIO.HeaderText = "Funcionario";
            this.FUNCIONARIO.Name = "FUNCIONARIO";
            this.FUNCIONARIO.ReadOnly = true;
            // 
            // DTRESPOSTA
            // 
            this.DTRESPOSTA.DataPropertyName = "DTRESPOSTA";
            this.DTRESPOSTA.HeaderText = "Data Resposta";
            this.DTRESPOSTA.Name = "DTRESPOSTA";
            this.DTRESPOSTA.ReadOnly = true;
            // 
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "IdPergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.ReadOnly = true;
            this.IDPERGUNTA.Visible = false;
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
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Pesquisa:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Funcionario:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(504, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(405, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Finalizadas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 345);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAnalise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analise de Respostas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMPANHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODFUNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTRESPOSTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}