namespace ProjetoAvaliacao.Formularios.Cadastro
{
    partial class frmCadastroFuncionario
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
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTVENCCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTVENCPRORROG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMHQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMHVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFAQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFAVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BONUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GESTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODGESTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME,
            this.FUNCAO,
            this.ADMISSAO,
            this.DEMISSAO,
            this.DTVENCCONTRATO,
            this.DTVENCPRORROG,
            this.CPF,
            this.SALARIO,
            this.SMQTDE,
            this.SMVALOR,
            this.AMHQTDE,
            this.AMHVALOR,
            this.AMQTDE,
            this.AMVALOR,
            this.DFQTDE,
            this.DFVALOR,
            this.DFAQTDE,
            this.DFAVALOR,
            this.MES,
            this.BONUS,
            this.SETOR,
            this.GESTOR,
            this.CODGESTOR,
            this.SENHA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 378);
            this.dataGridView1.TabIndex = 1;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // FUNCAO
            // 
            this.FUNCAO.DataPropertyName = "FUNCAO";
            this.FUNCAO.HeaderText = "Função";
            this.FUNCAO.Name = "FUNCAO";
            this.FUNCAO.ReadOnly = true;
            // 
            // ADMISSAO
            // 
            this.ADMISSAO.DataPropertyName = "DTADMISSAO";
            this.ADMISSAO.HeaderText = "Admissão";
            this.ADMISSAO.Name = "ADMISSAO";
            this.ADMISSAO.ReadOnly = true;
            // 
            // DEMISSAO
            // 
            this.DEMISSAO.DataPropertyName = "DTDEMISSAO";
            this.DEMISSAO.HeaderText = "Demissão";
            this.DEMISSAO.Name = "DEMISSAO";
            this.DEMISSAO.ReadOnly = true;
            // 
            // DTVENCCONTRATO
            // 
            this.DTVENCCONTRATO.DataPropertyName = "DTVENCCONTRATO";
            this.DTVENCCONTRATO.HeaderText = "Dt. Vecto Contrato";
            this.DTVENCCONTRATO.Name = "DTVENCCONTRATO";
            this.DTVENCCONTRATO.ReadOnly = true;
            // 
            // DTVENCPRORROG
            // 
            this.DTVENCPRORROG.DataPropertyName = "DTVENCCONTRATOPROG";
            this.DTVENCPRORROG.HeaderText = "Dt. Vecto Prorrogação";
            this.DTVENCPRORROG.Name = "DTVENCPRORROG";
            this.DTVENCPRORROG.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // SALARIO
            // 
            this.SALARIO.DataPropertyName = "SALARIO";
            this.SALARIO.HeaderText = "Salário";
            this.SALARIO.Name = "SALARIO";
            this.SALARIO.ReadOnly = true;
            // 
            // SMQTDE
            // 
            this.SMQTDE.DataPropertyName = "SALMESQTDE";
            this.SMQTDE.HeaderText = "Salario Mes Qtde";
            this.SMQTDE.Name = "SMQTDE";
            this.SMQTDE.ReadOnly = true;
            // 
            // SMVALOR
            // 
            this.SMVALOR.DataPropertyName = "SALMESVALOR";
            this.SMVALOR.HeaderText = "Salario Mes Valor";
            this.SMVALOR.Name = "SMVALOR";
            this.SMVALOR.ReadOnly = true;
            // 
            // AMHQTDE
            // 
            this.AMHQTDE.DataPropertyName = "ATESTADOQTDE";
            this.AMHQTDE.HeaderText = "Atestado Médico Hr Qtde";
            this.AMHQTDE.Name = "AMHQTDE";
            this.AMHQTDE.ReadOnly = true;
            // 
            // AMHVALOR
            // 
            this.AMHVALOR.DataPropertyName = "ATESTADOVALOR";
            this.AMHVALOR.HeaderText = "Atestado Médico Hr Valor";
            this.AMHVALOR.Name = "AMHVALOR";
            this.AMHVALOR.ReadOnly = true;
            // 
            // AMQTDE
            // 
            this.AMQTDE.DataPropertyName = "ATESTADOQTDEH";
            this.AMQTDE.HeaderText = "Atestado Médico Qtde";
            this.AMQTDE.Name = "AMQTDE";
            this.AMQTDE.ReadOnly = true;
            // 
            // AMVALOR
            // 
            this.AMVALOR.DataPropertyName = "ATESTADOVALORH";
            this.AMVALOR.HeaderText = "Atestado Médico Valor";
            this.AMVALOR.Name = "AMVALOR";
            this.AMVALOR.ReadOnly = true;
            // 
            // DFQTDE
            // 
            this.DFQTDE.DataPropertyName = "FALTASQTDEH";
            this.DFQTDE.HeaderText = "Desc. Faltas (DIAS) Qtde";
            this.DFQTDE.Name = "DFQTDE";
            this.DFQTDE.ReadOnly = true;
            // 
            // DFVALOR
            // 
            this.DFVALOR.DataPropertyName = "FALTASVALORH";
            this.DFVALOR.HeaderText = "Desc. Faltas (DIAS) Valor";
            this.DFVALOR.Name = "DFVALOR";
            this.DFVALOR.ReadOnly = true;
            // 
            // DFAQTDE
            // 
            this.DFAQTDE.DataPropertyName = "AUSENCIAQTDEH";
            this.DFAQTDE.HeaderText = "Desc. Faltas (DIAS) - Ausencia Qtde";
            this.DFAQTDE.Name = "DFAQTDE";
            this.DFAQTDE.ReadOnly = true;
            // 
            // DFAVALOR
            // 
            this.DFAVALOR.DataPropertyName = "AUSENCIAVALORH";
            this.DFAVALOR.HeaderText = "Desc. Faltas (DIAS) - Ausencia Valor";
            this.DFAVALOR.Name = "DFAVALOR";
            this.DFAVALOR.ReadOnly = true;
            // 
            // MES
            // 
            this.MES.DataPropertyName = "MES";
            this.MES.HeaderText = "Mês";
            this.MES.Name = "MES";
            this.MES.ReadOnly = true;
            this.MES.Visible = false;
            // 
            // BONUS
            // 
            this.BONUS.DataPropertyName = "ABONAR";
            this.BONUS.HeaderText = "Bônus";
            this.BONUS.Name = "BONUS";
            this.BONUS.ReadOnly = true;
            // 
            // SETOR
            // 
            this.SETOR.DataPropertyName = "SETOR";
            this.SETOR.HeaderText = "Setor";
            this.SETOR.Name = "SETOR";
            this.SETOR.ReadOnly = true;
            // 
            // GESTOR
            // 
            this.GESTOR.DataPropertyName = "GESTOR";
            this.GESTOR.HeaderText = "Gestor";
            this.GESTOR.Name = "GESTOR";
            this.GESTOR.ReadOnly = true;
            // 
            // CODGESTOR
            // 
            this.CODGESTOR.DataPropertyName = "CODGESTOR";
            this.CODGESTOR.HeaderText = "Cod. Gestor";
            this.CODGESTOR.Name = "CODGESTOR";
            this.CODGESTOR.ReadOnly = true;
            // 
            // SENHA
            // 
            this.SENHA.DataPropertyName = "SENHA";
            this.SENHA.HeaderText = "Senha";
            this.SENHA.Name = "SENHA";
            this.SENHA.ReadOnly = true;
            this.SENHA.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(703, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADMISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEMISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTVENCCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTVENCPRORROG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMQTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMHQTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMHVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMQTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFQTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFAQTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFAVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MES;
        private System.Windows.Forms.DataGridViewTextBoxColumn BONUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn GESTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODGESTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENHA;
    }
}