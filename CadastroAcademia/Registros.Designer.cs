namespace CadastroAcademia
{
    partial class Registros
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnAtualizarAlunos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pnlDdvAlunos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDdvAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 66);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Aluno";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlunos.Location = new System.Drawing.Point(0, 0);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(1123, 425);
            this.dgvAlunos.TabIndex = 1;
            // 
            // btnAtualizarAlunos
            // 
            this.btnAtualizarAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizarAlunos.Location = new System.Drawing.Point(1036, 101);
            this.btnAtualizarAlunos.Name = "btnAtualizarAlunos";
            this.btnAtualizarAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarAlunos.TabIndex = 2;
            this.btnAtualizarAlunos.Text = "Atualizar";
            this.btnAtualizarAlunos.UseVisualStyleBackColor = true;
            this.btnAtualizarAlunos.Click += new System.EventHandler(this.btnAtualizarAlunos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnAtualizarAlunos);
            this.panel1.Controls.Add(this.pnlDdvAlunos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 555);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Location = new System.Drawing.Point(327, 104);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(476, 20);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.Location = new System.Drawing.Point(114, 101);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletar.Location = new System.Drawing.Point(12, 101);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // pnlDdvAlunos
            // 
            this.pnlDdvAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDdvAlunos.Controls.Add(this.dgvAlunos);
            this.pnlDdvAlunos.Location = new System.Drawing.Point(0, 130);
            this.pnlDdvAlunos.Name = "pnlDdvAlunos";
            this.pnlDdvAlunos.Size = new System.Drawing.Size(1123, 425);
            this.pnlDdvAlunos.TabIndex = 0;
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 555);
            this.Controls.Add(this.panel1);
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDdvAlunos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnAtualizarAlunos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDdvAlunos;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}