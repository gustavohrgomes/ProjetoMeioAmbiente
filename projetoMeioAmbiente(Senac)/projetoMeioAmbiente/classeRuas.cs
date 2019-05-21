using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace projetoMeioAmbiente
{
    class classeRuas
    {
        SqlConnection con;
        conexaoBanco Banco = new conexaoBanco();

        public void Cadastrar_rua(string endereco, string cep, string bairro, string cidade, int qntdCasas, int qntdArvores)
        {
            con = Banco.abrir_Conexao();
            string Inserir = @"INSERT INTO ruas(endereco,cep,bairro,cidade,qntdCasas,qntdArvores)" + "VALUES (@Endereco,@Cep,@Bairro,@Cidade,@qntdCasas,@qntdArvores)";

            SqlCommand cmd = new SqlCommand(Inserir, con);
            cmd.Parameters.AddWithValue("@Endereco", endereco);
            cmd.Parameters.AddWithValue("@Cep", cep);
            cmd.Parameters.AddWithValue("@Bairro", bairro);
            cmd.Parameters.AddWithValue("@Cidade", cidade);
            cmd.Parameters.AddWithValue("@qntdCasas", qntdCasas);
            cmd.Parameters.AddWithValue("@qntdArvores", qntdArvores);

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Dados inseridos com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }                                   
        }

        public void Consultar_Rua(DataGridView dataGridView, string busca)
        {
            con = Banco.abrir_Conexao();
            string selecionar = @"SELECT * FROM ruas WHERE endereco like '%" + busca + "%'";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selecionar, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: ", ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Excluir_Rua(string id_rua, string busca, DataGridView dgvConsultaRua)
        {
            
                con = Banco.abrir_Conexao();
                string deletar = @"DELETE FROM ruas WHERE id_rua=@Id";                
                SqlCommand cmd = new SqlCommand(deletar, con);
                cmd.Parameters.AddWithValue("@Id", id_rua);
                cmd.CommandType = CommandType.Text;
                
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro excluído com sucesso!", "Messagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Atualizar_datagrid(dgvConsultaRua, busca);
                    con.Close();
                }
                        
        }

        public void Atualizar_datagrid(DataGridView dgvConsultaRua, string busca)
        {
            con = Banco.abrir_Conexao();
            string Selecionar = @"SELECT * FROM ruas";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Selecionar, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvConsultaRua.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Atualizar_rua(string endereco, string cep, string bairro, string cidade, int qntdCasas, int qntdArvores, int id_rua)
        {
            con = Banco.abrir_Conexao();
            string update = @"UPDATE ruas SET endereco=@Endereco, cep=@Cep, bairro=@Bairro, cidade=@Cidade, qntdCasas=@qntdCasas, qntdArvores=@qntdArvores WHERE id_rua=@idRua";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.Parameters.AddWithValue("@idRua", id_rua);
            cmd.Parameters.AddWithValue("@Endereco", endereco);
            cmd.Parameters.AddWithValue("@Cep", cep);
            cmd.Parameters.AddWithValue("@Bairro", bairro);
            cmd.Parameters.AddWithValue("@Cidade", cidade);
            cmd.Parameters.AddWithValue("@qntdCasas", qntdCasas);
            cmd.Parameters.AddWithValue("@qntdArvores", qntdArvores);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {                
                con.Close();
            }
        }
    }
}
