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
            this.ACAOGESTOR,
            this.DTPRAZO,
            this.OBSERVACAO});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(899, 353);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(836, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "* digite o prazo no formato dd/MM/aaaa com as barras - EX: (01/01/2025) *";
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
            this.PERGUNTA.DataPropertyName = "PERGUNTA";
            this.PERGUNTA.HeaderText = "Pergunta";
            this.PERGUNTA.Name = "PERGUNTA";
            this.PERGUNTA.Width = 143;
            // 
            // RESPOSTA
            // 
            this.RESPOSTA.DataPropertyName = "RESPOSTAFUNC";
            this.RESPOSTA.HeaderText = "Resposta";
            this.RESPOSTA.Name = "RESPOSTA";
            this.RESPOSTA.Width = 122;
            // 
            // COMENTARIO
            // 
            this.COMENTARIO.DataPropertyName = "COMENTARIOFUNC";
            this.COMENTARIO.HeaderText = "Comentario";
            this.COMENTARIO.Name = "COMENTARIO";
            this.COMENTARIO.Width = 144;
            // 
            // ACAOGESTOR
            // 
            this.ACAOGESTOR.DataPropertyName = "ACOESGESTOR";
            this.ACAOGESTOR.HeaderText = "Ação";
            this.ACAOGESTOR.Name = "ACAOGESTOR";
            this.ACAOGESTOR.Width = 121;
            // 
            // DTPRAZO
            // 
            this.DTPRAZO.DataPropertyName = "DTPRAZO";
            this.DTPRAZO.HeaderText = "Data Prazo";
            this.DTPRAZO.Name = "DTPRAZO";
            // 
            // OBSERVACAO
            // 
            this.OBSERVACAO.DataPropertyName = "OBSERVACAO";
            this.OBSERVACAO.HeaderText = "Observação";
            this.OBSERVACAO.Name = "OBSERVACAO";
            this.OBSERVACAO.Width = 143;
            // 
            // frmAnaliseResposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ACAOGESTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTPRAZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACAO;
    }
}