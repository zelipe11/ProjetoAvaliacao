namespace ProjetoAvaliacao.Formularios.Analise
{
    partial class frmAnaliseResposta
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPERG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESPOSTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTARESP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ACAOGESTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPRAZO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Funcionario/Anonimo - Campanha";
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
            this.IDPERGUNTA,
            this.CODPERG,
            this.PERGUNTA,
            this.RESPOSTA,
            this.COMENTARIO,
            this.NOTARESP,
            this.ACAOGESTOR,
            this.DTPRAZO,
            this.OBSERVACAO});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 353);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "* digite apenas o número de dias no prazo *";
            // 
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "IdPergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.Visible = false;
            // 
            // CODPERG
            // 
            this.CODPERG.DataPropertyName = "CODPERG";
            this.CODPERG.HeaderText = "cod";
            this.CODPERG.Name = "CODPERG";
            this.CODPERG.Visible = false;
            // 
            // PERGUNTA
            // 
            this.PERGUNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PERGUNTA.DataPropertyName = "PERGUNTA";
            this.PERGUNTA.HeaderText = "Pergunta";
            this.PERGUNTA.Name = "PERGUNTA";
            // 
            // RESPOSTA
            // 
            this.RESPOSTA.DataPropertyName = "RESPOSTAFUNC";
            this.RESPOSTA.HeaderText = "Resposta";
            this.RESPOSTA.Name = "RESPOSTA";
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COMENTARIO.DataPropertyName = "COMENTARIOFUNC";
            this.COMENTARIO.HeaderText = "Comentario";
            this.COMENTARIO.Name = "COMENTARIO";
            // 
            // NOTARESP
            // 
            this.NOTARESP.DataPropertyName = "RESPOSTA";
            this.NOTARESP.HeaderText = "Nota Resposta";
            this.NOTARESP.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.NOTARESP.Name = "NOTARESP";
            this.NOTARESP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOTARESP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ACAOGESTOR
            // 
            this.ACAOGESTOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ACAOGESTOR.DataPropertyName = "ACAOGESTOR";
            this.ACAOGESTOR.HeaderText = "Ação";
            this.ACAOGESTOR.Name = "ACAOGESTOR";
            // 
            // DTPRAZO
            // 
            this.DTPRAZO.DataPropertyName = "DTPRAZO";
            this.DTPRAZO.HeaderText = "Dias Prazo";
            this.DTPRAZO.Name = "DTPRAZO";
            // 
            // OBSERVACAO
            // 
            this.OBSERVACAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OBSERVACAO.DataPropertyName = "OBSERVACAO";
            this.OBSERVACAO.HeaderText = "Observação";
            this.OBSERVACAO.Name = "OBSERVACAO";
            // 
            // frmAnaliseResposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmAnaliseResposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analise Resposta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPERG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERGUNTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESPOSTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
        private System.Windows.Forms.DataGridViewComboBoxColumn NOTARESP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACAOGESTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTPRAZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACAO;
    }
}