using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAcademia
{
    public partial class Alterar : Form
    {
        
        private int alunoId;
        public Alterar(int id, string nome, DateTime dataNascimento, string email, string telefone, decimal peso, decimal altura, int planoId, int modalidadeId, string planoNome, string modalidadeNome)
        {
            InitializeComponent();

            alunoId = id;
            CarregarComboPlanos();
            CarregarComboModalidades();

            txtNome.Text = nome;
            mtbData.Text = dataNascimento.ToString();
            txtEmail.Text = email;
            mtbTelefone.Text = telefone;
            txtPeso.Text = peso.ToString();
            txtAltura.Text = altura.ToString();
            cmbPlano.SelectedValue = planoId;
            cmbModalidade.SelectedValue = modalidadeId;

        }
        private void CarregarComboPlanos()
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string query = "SELECT Id, Nome FROM Planos";
                SqlDataAdapter da = new SqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPlano.DataSource = dt;
                cmbPlano.DisplayMember = "Nome";
                cmbPlano.ValueMember = "Id";
            }
        }

        private void CarregarComboModalidades()
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string query = "SELECT Id, Nome FROM Modalidades";
                SqlDataAdapter da = new SqlDataAdapter(query, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbModalidade.DataSource = dt;
                cmbModalidade.DisplayMember = "Nome";
                cmbModalidade.ValueMember = "Id";
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {

                string query = "UPDATE Alunos SET " +
                                "Nome = @nome, " +
                                "DataNascimento = @dataNascimento, " +
                                "Email = @email, " +
                                "Telefone = @telefone, " +
                                "Peso = @peso, " +
                                "Altura = @altura, " +
                                "PlanosId = @planosId, " +
                                "ModalidadeId = @modalidadeId " +
                                "WHERE Id = @id";

                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", txtNome.Text);

                    if (!DateTime.TryParse(mtbData.Text, out DateTime dataNascimento))
                    {
                        MessageBox.Show("Data inválida.");
                        return;
                    }
                    comando.Parameters.AddWithValue("@DataNascimento", dataNascimento);

                    comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@Telefone", mtbTelefone.Text);

                    if (!decimal.TryParse(txtPeso.Text, out decimal peso))
                    {
                        MessageBox.Show("Peso inválido.");
                        return;
                    }
                    comando.Parameters.AddWithValue("@Peso", peso);

                    if (!decimal.TryParse(txtAltura.Text, out decimal altura))
                    {
                        MessageBox.Show("Altura inválida.");
                        return;
                    }
                    comando.Parameters.AddWithValue("@Altura", altura);

                    if (cmbPlano.SelectedValue != null && int.TryParse(cmbPlano.SelectedValue.ToString(), out int planosId))
                        comando.Parameters.AddWithValue("@PlanosId", planosId);
                    else
                    {
                        MessageBox.Show("Plano inválido");
                        return;
                    }

                    if (cmbModalidade.SelectedValue != null && int.TryParse(cmbModalidade.SelectedValue.ToString(), out int modalidadeId))
                        comando.Parameters.AddWithValue("@ModalidadeId", modalidadeId);
                    else
                    {
                        MessageBox.Show("Modalidade inválida");
                        return;
                    }

                    comando.Parameters.AddWithValue("@id", alunoId);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado!");
                    this.Close();
                }
            }
        }
       
        private void Alterar_Load(object sender, EventArgs e)
        {

            TelaInicial.Personalizacao(this.Controls);
        }

        
    }
}
