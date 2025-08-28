namespace CadastroAcademia
{
    partial class TelaInicial
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
            this.txtCref = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblCref = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCref
            // 
            this.txtCref.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCref.Location = new System.Drawing.Point(429, 195);
            this.txtCref.Name = "txtCref";
            this.txtCref.Size = new System.Drawing.Size(226, 20);
            this.txtCref.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Location = new System.Drawing.Point(429, 269);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(226, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.Location = new System.Drawing.Point(506, 318);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblCref
            // 
            this.lblCref.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCref.AutoSize = true;
            this.lblCref.Location = new System.Drawing.Point(524, 159);
            this.lblCref.Name = "lblCref";
            this.lblCref.Size = new System.Drawing.Size(26, 13);
            this.lblCref.TabIndex = 8;
            this.lblCref.Text = "Cref";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(524, 234);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblCref);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtCref);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 531);
            this.panel1.TabIndex = 6;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 531);
            this.Controls.Add(this.panel1);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acad";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCref;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblCref;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel panel1;
    }
}

