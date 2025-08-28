using System;
using System.Collections;
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
    
    public partial class Registros : Form
    {
       
        private DataTable dtAlunos;

        public Registros()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro telaCadastro = new Cadastro();
            telaCadastro.ShowDialog();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            CarregarAlunos();

            dgvAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlunos.MultiSelect = false;
            dgvAlunos.ClearSelection();
            // Fundo escuro
            this.BackColor = Color.FromArgb(30, 30, 30);

            // Botão cadastrar
            btnCadastrar.BackColor = Color.FromArgb(0, 122, 204);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Botão atualizar
            btnAtualizarAlunos.BackColor = Color.FromArgb(0, 122, 204);
            btnAtualizarAlunos.ForeColor = Color.White;
            btnAtualizarAlunos.FlatStyle = FlatStyle.Flat;
            btnAtualizarAlunos.FlatAppearance.BorderSize = 0;
            btnAtualizarAlunos.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // DataGridView estilizado
            dgvAlunos.EnableHeadersVisualStyles = false;
            dgvAlunos.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvAlunos.BorderStyle = BorderStyle.None;
            dgvAlunos.GridColor = Color.Gray;

            dgvAlunos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvAlunos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAlunos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAlunos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvAlunos.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgvAlunos.DefaultCellStyle.ForeColor = Color.White;
            dgvAlunos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvAlunos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAlunos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvAlunos.RowHeadersVisible = false;
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
            dgvAlunos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

        }


        private void btnAtualizarAlunos_Click(object sender, EventArgs e)
        {
            CarregarAlunos();
        }
        private void CarregarAlunos()
        {
            using (SqlConnection conexao = Conexao.ObterConexao())
            {
                try
                {
                    string query = @"SELECT 
                                    a.Id,
                                    a.Nome,
                                    a.DataNascimento,
                                    a.Email,
                                    a.Telefone,
                                    a.Peso,
                                    a.Altura,
                                    a.PlanosID AS PlanoID,          
                                    p.Nome AS Plano,                
                                    a.ModalidadeID AS ModalidadeID, 
                                    m.Nome AS Modalidade            
                                FROM Alunos a
                                JOIN Planos p ON a.PlanosID = p.Id
                                JOIN Modalidades m ON a.ModalidadeID = m.Id";


                    SqlDataAdapter executaQuery = new SqlDataAdapter(query, conexao);
                    dtAlunos = new DataTable();
                    executaQuery.Fill(dtAlunos);
                    dgvAlunos.DataSource = dtAlunos;

                    dgvAlunos.AutoGenerateColumns = true;
                    dgvAlunos.DataSource = dtAlunos;

                    //Estilo
                    dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvAlunos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    dgvAlunos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvAlunos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvAlunos.GridColor = Color.LightGray;
                    dgvAlunos.EnableHeadersVisualStyles = false;
                    dgvAlunos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
                    dgvAlunos.BorderStyle = BorderStyle.None;
                    dgvAlunos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
                    dgvAlunos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

                    dgvAlunos.Columns["Id"].Visible = false;
                    dgvAlunos.Columns["PlanoID"].Visible = false;
                    dgvAlunos.Columns["ModalidadeID"].Visible = false;

                    dgvAlunos.Columns["Nome"].HeaderText = "Nome";
                    dgvAlunos.Columns["DataNascimento"].HeaderText = "Nascimento";
                    dgvAlunos.Columns["Email"].HeaderText = "E-mail";
                    dgvAlunos.Columns["Telefone"].HeaderText = "Telefone";
                    dgvAlunos.Columns["Peso"].HeaderText = "Peso";
                    dgvAlunos.Columns["Altura"].HeaderText = "Altura";
                    dgvAlunos.Columns["Plano"].HeaderText = "Plano";
                    dgvAlunos.Columns["Modalidade"].HeaderText = "Modalidade";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dgvAlunos.SelectedRows[0];

                int idAluno = Convert.ToInt32(linhaSelecionada.Cells["Id"].Value);
                DialogResult confirmarExclusao = MessageBox.Show("Tem certeza que deseja excluir esse aluno?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarExclusao == DialogResult.Yes)
                {
                    using (SqlConnection conexao = Conexao.ObterConexao())
                    {
                        string query = "DELETE FROM Alunos WHERE Id = @Id";

                        using (SqlCommand comando = new SqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@Id", idAluno);
                            dgvAlunos.ClearSelection();
                            Console.WriteLine(dgvAlunos.CurrentRow.Cells["Id"].Value);
                            try
                            {
                                conexao.Open();
                                int linhasAfetadas = comando.ExecuteNonQuery();

                                if (linhasAfetadas > 0)
                                {
                                    MessageBox.Show("Aluno deletado com sucesso");
                                    CarregarAlunos();
                                    dgvAlunos.ClearSelection();

                                }
                                else
                                {
                                    MessageBox.Show("Erro ao deletar aluno");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um aluno para deletar!");
                }
            }

        }


        private void panel1_Click(object sender, EventArgs e)
        {
            dgvAlunos.ClearSelection();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedCells.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvAlunos.CurrentRow.Cells["Id"].Value);
                    string nome = dgvAlunos.CurrentRow.Cells["Nome"].Value.ToString();
                    DateTime dataNascimento = Convert.ToDateTime(dgvAlunos.CurrentRow.Cells["DataNascimento"].Value);
                    string email = dgvAlunos.CurrentRow.Cells["Email"].Value?.ToString();
                    string telefone = dgvAlunos.CurrentRow.Cells["Telefone"].Value?.ToString();
                    decimal peso = Convert.ToDecimal(dgvAlunos.CurrentRow.Cells["Peso"].Value);
                    decimal altura = Convert.ToDecimal(dgvAlunos.CurrentRow.Cells["Altura"].Value);

                    int planoid = Convert.ToInt32(dgvAlunos.CurrentRow.Cells["PlanoID"].Value);
                    int modalidadeid = Convert.ToInt32(dgvAlunos.CurrentRow.Cells["ModalidadeID"].Value);

                    string planoNome = dgvAlunos.CurrentRow.Cells["Plano"].Value.ToString();
                    string modalidadeNome = dgvAlunos.CurrentRow.Cells["Modalidade"].Value.ToString();

                    Alterar alterar = new Alterar(id, nome, dataNascimento, email, telefone, peso, altura, planoid, modalidadeid, planoNome, modalidadeNome);
                    alterar.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar informações: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Selecione um aluno para alterar");
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (dtAlunos != null)
            {
                string filtro = txtPesquisar.Text.Replace("'", "''");
                dtAlunos.DefaultView.RowFilter =
                    $"Nome LIKE '%{filtro}%' OR Email LIKE '%{filtro}%'";
            }
        }
    }
}
