namespace CadastroAcademia
{
    partial class Alterar
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
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.cmbModalidade = new System.Windows.Forms.ComboBox();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPlano
            // 
            this.cmbPlano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(361, 323);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(141, 21);
            this.cmbPlano.TabIndex = 22;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbTelefone.HidePromptOnLeave = true;
            this.mtbTelefone.Location = new System.Drawing.Point(361, 209);
            this.mtbTelefone.Mask = "(00)00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.PromptChar = ' ';
            this.mtbTelefone.Size = new System.Drawing.Size(141, 20);
            this.mtbTelefone.TabIndex = 19;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbData
            // 
            this.mtbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbData.HidePromptOnLeave = true;
            this.mtbData.Location = new System.Drawing.Point(361, 131);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.PromptChar = ' ';
            this.mtbData.Size = new System.Drawing.Size(141, 20);
            this.mtbData.TabIndex = 17;
            this.mtbData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // cmbModalidade
            // 
            this.cmbModalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModalidade.FormattingEnabled = true;
            this.cmbModalidade.Location = new System.Drawing.Point(361, 369);
            this.cmbModalidade.Name = "cmbModalidade";
            this.cmbModalidade.Size = new System.Drawing.Size(141, 21);
            this.cmbModalidade.TabIndex = 23;
            // 
            // lblModalidade
            // 
            this.lblModalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(191, 372);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(62, 13);
            this.lblModalidade.TabIndex = 31;
            this.lblModalidade.Text = "Modalidade";
            // 
            // lblPlano
            // 
            this.lblPlano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlano.AutoSize = true;
            this.lblPlano.Location = new System.Drawing.Point(191, 331);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(34, 13);
            this.lblPlano.TabIndex = 30;
            this.lblPlano.Text = "Plano";
            // 
            // lblAltura
            // 
            this.lblAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(191, 290);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 29;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(191, 253);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 28;
            this.lblPeso.Text = "Peso";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(191, 212);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(191, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(191, 134);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataNascimento.TabIndex = 25;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(191, 99);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(361, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltura.Location = new System.Drawing.Point(361, 283);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(141, 20);
            this.txtAltura.TabIndex = 21;
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeso.Location = new System.Drawing.Point(361, 246);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(141, 20);
            this.txtPeso.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(361, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 20);
            this.txtNome.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPeso);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Controls.Add(this.mtbTelefone);
            this.panel1.Controls.Add(this.cmbPlano);
            this.panel1.Controls.Add(this.lblAltura);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.mtbData);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lblPlano);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblDataNascimento);
            this.panel1.Controls.Add(this.lblModalidade);
            this.panel1.Controls.Add(this.cmbModalidade);
            this.panel1.Controls.Add(this.txtAltura);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 561);
            this.panel1.TabIndex = 32;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Location = new System.Drawing.Point(640, 448);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(137, 62);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 561);
            this.Controls.Add(this.panel1);
            this.Name = "Alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar ";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.ComboBox cmbModalidade;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
    }
}