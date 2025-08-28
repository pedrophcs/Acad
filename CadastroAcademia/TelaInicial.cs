using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace CadastroAcademia
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            //bool modoTeste = true;

            //if (modoTeste)
            //{
            //    Application.Run(new Registros()); 
            //}
            //else
            //{
            //    Application.Run(new TelaInicial());
            //}
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string cref = txtCref.Text.Trim();
            string senha = txtSenha.Text.Trim();


            using (SqlConnection conexao = Conexao.ObterConexao()) 
            {
                string query = "SELECT COUNT(*) FROM Professores WHERE CREF = @cref AND SENHA = @senha";

                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@cref", cref);
                    comando.Parameters.AddWithValue("@senha", senha);

                    try
                    {
                        conexao.Open();
                        int resultado = (int)comando.ExecuteScalar();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Login bem sucedido");
                            Registros reg = new Registros();
                            reg.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na conexão: " + ex.Message);


                    }



                }
            }


        }
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            Personalizacao(this.Controls);
            txtSenha.PasswordChar = '●';
            lblCref.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSenha.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            //// Botão estilizado
            //btnEntrar.FlatStyle = FlatStyle.Flat;
            //btnEntrar.FlatAppearance.BorderSize = 0;
            //btnEntrar.BackColor = Color.FromArgb(0, 122, 204);
            //btnEntrar.ForeColor = Color.White;
            //btnEntrar.Font = new Font("Segoe UI", 10, FontStyle.Bold);


        }


        public static void Personalizacao(Control.ControlCollection controles)
        {

            foreach (Control controle in controles)
            {
                if (controle is TextBox)
                {
                    controle.BackColor = Color.FromArgb(50, 50, 50);
                    controle.ForeColor = Color.White;
                    controle.Font = new Font("Segoe UI", 10);
                }
                else if (controle is Button btn)
                {
                    btn.BackColor = Color.FromArgb(0, 122, 204);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else if (controle is ComboBox)
                {
                    controle.BackColor = Color.FromArgb(50, 50, 50);
                    controle.ForeColor = Color.White;
                    controle.Font = new Font("Segoe UI", 10);
                }
                else if (controle is Label)
                {
                    controle.ForeColor = Color.White;
                    controle.Font = new Font("Segoe UI", 10);
                }
                else if (controle is DateTimePicker)
                {
                    controle.BackColor = Color.FromArgb(50, 50, 50);
                    controle.ForeColor = Color.White;
                    controle.Font = new Font("Segoe UI", 10);
                }
                else if (controle is MaskedTextBox)
                {
                    controle.BackColor = Color.FromArgb(50, 50, 50);
                    controle.ForeColor = Color.White;
                    controle.Font = new Font("Segoe UI", 10);
                }
                else if (controle is Panel)
                {
                    controle.BackColor = Color.FromArgb(40, 40, 40);
                }
                Personalizacao(controle.Controls);
            }

        }

    }
}

