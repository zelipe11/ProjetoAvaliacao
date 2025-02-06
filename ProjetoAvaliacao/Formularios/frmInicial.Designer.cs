namespace ProjetoAvaliacao
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAvaliacao = new System.Windows.Forms.Button();
            this.btnAnalise = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(229, 65);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAvaliacao
            // 
            this.btnAvaliacao.Location = new System.Drawing.Point(12, 88);
            this.btnAvaliacao.Name = "btnAvaliacao";
            this.btnAvaliacao.Size = new System.Drawing.Size(229, 65);
            this.btnAvaliacao.TabIndex = 1;
            this.btnAvaliacao.Text = "Avaliação";
            this.btnAvaliacao.UseVisualStyleBackColor = true;
            this.btnAvaliacao.Click += new System.EventHandler(this.btnAvaliacao_Click);
            // 
            // btnAnalise
            // 
            this.btnAnalise.Location = new System.Drawing.Point(12, 164);
            this.btnAnalise.Name = "btnAnalise";
            this.btnAnalise.Size = new System.Drawing.Size(229, 65);
            this.btnAnalise.TabIndex = 2;
            this.btnAnalise.Text = "Analise";
            this.btnAnalise.UseVisualStyleBackColor = true;
            // 
            // btnResultados
            // 
            this.btnResultados.Location = new System.Drawing.Point(12, 240);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(229, 65);
            this.btnResultados.TabIndex = 3;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versão 0.0.1";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnAnalise);
            this.Controls.Add(this.btnAvaliacao);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação ou Pesquisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAvaliacao;
        private System.Windows.Forms.Button btnAnalise;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.Label label1;
    }
}

