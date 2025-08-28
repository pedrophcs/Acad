using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastroAcademia
{
    public partial class Cadastro : Form
    {



        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                string queryCadastrar = "INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, PlanosID, ModalidadeID) VALUES (@Nome, @DataNascimento, @Email, @Telefone, @Peso, @Altura, @PlanosID, @ModalidadeID)";

                using (SqlCommand comando = new SqlCommand(queryCadastrar, conexao))
                {
                    int planoId = (int)cmbPlano.SelectedValue;
                    int modalidadeId = (int)cmbModalidade.SelectedValue;

                    comando.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = txtNome.Text;
                    if (DateTime.TryParseExact(mtbData.Text, "dd/mm/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out DateTime dataNascimento))
                    {
                        comando.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = dataNascimento;
                    }
                    else
                    {
                        MessageBox.Show("Formato de data inválido. Requerido: dd/mm/aaaa\nValor digitado: " + mtbData.Text);
                        return;
                    }

                    comando.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    comando.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = mtbTelefone.Text;
                    if (decimal.TryParse(txtPeso.Text, out decimal peso) &&
                        decimal.TryParse(txtAltura.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out decimal altura))
                    {
                        comando.Parameters.Add("@Peso", SqlDbType.Decimal).Value = peso;
                        comando.Parameters.Add("@Altura", SqlDbType.Decimal).Value = altura;
                    }
                    else
                    {
                        MessageBox.Show("Peso ou altura inválidos");
                        return;
                    }
                    comando.Parameters.Add("@PlanosID", SqlDbType.Int).Value = planoId;
                    comando.Parameters.Add("@ModalidadeID", SqlDbType.NVarChar).Value = modalidadeId;

                    try
                    {
                        conexao.Open();
                        int linhasAfetadas = comando.ExecuteNonQuery();
                        MessageBox.Show("Cadastro efetuado");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }


            }

        }

        private void mtbData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbData.Text.Replace("/", "").Trim() == "")
            {
                mtbData.ResetText();
            }
        }

        private void cmbPlano_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    string query = "SELECT Id, Nome FROM Planos";
                    SqlDataAdapter executaSelect = new SqlDataAdapter(query, conexao);
                    DataTable guardaMemoria = new DataTable();
                    executaSelect.Fill(guardaMemoria);
                    cmbPlano.DisplayMember = "Nome";
                    cmbPlano.ValueMember = "Id";
                    cmbPlano.DataSource = guardaMemoria;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os planos: " + ex.Message);
                }
            }
        }

        private void cmbModalidade_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    string query = "SELECT Id, Nome FROM Modalidades";
                    SqlDataAdapter executaSelect = new SqlDataAdapter(query, conexao);
                    DataTable guardaMemoria = new DataTable();
                    executaSelect.Fill(guardaMemoria);
                    cmbModalidade.DisplayMember = "Nome";
                    cmbModalidade.ValueMember = "Id";
                    cmbModalidade.DataSource = guardaMemoria;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao carregar as modalidades: " + ex.Message);
                }
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            TelaInicial.Personalizacao(this.Controls);

        }

    }
}

