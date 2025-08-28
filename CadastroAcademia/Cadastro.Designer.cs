namespace CadastroAcademia
{
    partial class Cadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbModalidade = new System.Windows.Forms.ComboBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cmbPlano = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Location = new System.Drawing.Point(318, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 54);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(12, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeso.Location = new System.Drawing.Point(12, 163);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(141, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltura.Location = new System.Drawing.Point(228, 163);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(141, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(408, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(65, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Plano";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Modalidade";
            // 
            // cmbModalidade
            // 
            this.cmbModalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModalidade.FormattingEnabled = true;
            this.cmbModalidade.Location = new System.Drawing.Point(587, 163);
            this.cmbModalidade.Name = "cmbModalidade";
            this.cmbModalidade.Size = new System.Drawing.Size(141, 21);
            this.cmbModalidade.TabIndex = 7;
            this.cmbModalidade.DropDown += new System.EventHandler(this.cmbModalidade_DropDown);
            // 
            // mtbData
            // 
            this.mtbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbData.HidePromptOnLeave = true;
            this.mtbData.Location = new System.Drawing.Point(228, 72);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.PromptChar = ' ';
            this.mtbData.Size = new System.Drawing.Size(141, 20);
            this.mtbData.TabIndex = 1;
            this.mtbData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbData_MaskInputRejected);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtbTelefone.HidePromptOnLeave = true;
            this.mtbTelefone.Location = new System.Drawing.Point(587, 72);
            this.mtbTelefone.Mask = "(00)00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.PromptChar = ' ';
            this.mtbTelefone.Size = new System.Drawing.Size(141, 20);
            this.mtbTelefone.TabIndex = 3;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbPlano
            // 
            this.cmbPlano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlano.FormattingEnabled = true;
            this.cmbPlano.Location = new System.Drawing.Point(417, 163);
            this.cmbPlano.Name = "cmbPlano";
            this.cmbPlano.Size = new System.Drawing.Size(121, 21);
            this.cmbPlano.TabIndex = 6;
            this.cmbPlano.DropDown += new System.EventHandler(this.cmbPlano_DropDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.mtbTelefone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 514);
            this.panel1.TabIndex = 9;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 514);
            this.Controls.Add(this.cmbPlano);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.cmbModalidade);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbModalidade;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.ComboBox cmbPlano;
        private System.Windows.Forms.Panel panel1;
    }
}