namespace ProjetoAvaliacao.Formularios.Avaliacao
{
    partial class frmAvaliacao
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
            this.IDAVALIACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODFUNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTINICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERGUNTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.IDAVALIACAO,
            this.CODFUNC,
            this.FUNCIONARIO,
            this.DTINICIO,
            this.DTFIM,
            this.IDPERGUNTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(666, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // IDAVALIACAO
            // 
            this.IDAVALIACAO.DataPropertyName = "IDAVALIACAO";
            this.IDAVALIACAO.HeaderText = "idavaliaca";
            this.IDAVALIACAO.Name = "IDAVALIACAO";
            this.IDAVALIACAO.ReadOnly = true;
            this.IDAVALIACAO.Visible = false;
            // 
            // CODFUNC
            // 
            this.CODFUNC.DataPropertyName = "CODFUNC";
            this.CODFUNC.HeaderText = "codfunc";
            this.CODFUNC.Name = "CODFUNC";
            this.CODFUNC.ReadOnly = true;
            this.CODFUNC.Visible = false;
            // 
            // FUNCIONARIO
            // 
            this.FUNCIONARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FUNCIONARIO.DataPropertyName = "FUNCIONARIO";
            this.FUNCIONARIO.HeaderText = "Funcionario";
            this.FUNCIONARIO.Name = "FUNCIONARIO";
            this.FUNCIONARIO.ReadOnly = true;
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
            // IDPERGUNTA
            // 
            this.IDPERGUNTA.DataPropertyName = "IDPERGUNTA";
            this.IDPERGUNTA.HeaderText = "idpergunta";
            this.IDPERGUNTA.Name = "IDPERGUNTA";
            this.IDPERGUNTA.ReadOnly = true;
            this.IDPERGUNTA.Visible = false;
            // 
            // frmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 278);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAvaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAVALIACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODFUNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTINICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTFIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERGUNTA;
    }
}