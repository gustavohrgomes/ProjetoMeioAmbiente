using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
    


namespace projetoMeioAmbiente
{
    class classeArvores
    {
        SqlConnection con;
        conexaoBanco Banco = new conexaoBanco();

        public void Cadastrar_Arvore(int id_rua, string especie, int numeroCasa, string tipoArvore, string projecaoSombra, string perimetro, string gps)
        {
            con = Banco.abrir_Conexao();
            string inserir = @"INSERT INTO arvores(id_rua,especie,numeroCasa,tipoArvore,projecaoSombra,perimetro,gps) " + "VALUES (@id_rua, @Especie, @numeroCasa, @tipoArvore, @Sombra, @Perimetro, @Gps)";
            SqlCommand cmd = new SqlCommand(inserir, con);
            cmd.Parameters.AddWithValue("@id_rua", id_rua);
            cmd.Parameters.AddWithValue("@Especie", especie);
            cmd.Parameters.AddWithValue("@numeroCasa", numeroCasa);
            cmd.Parameters.AddWithValue("@tipoArvore", tipoArvore);
            cmd.Parameters.AddWithValue("@Sombra", projecaoSombra);
            cmd.Parameters.AddWithValue("@Perimetro", perimetro);
            cmd.Parameters.AddWithValue("@Gps", gps);

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Dados inseridos com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void Consultar_arvores(DataGridView dataGridView, string busca)
        {
            con = Banco.abrir_Conexao();
            string selecionar = @"SELECT id_arvore,id_rua,especie,numeroCasa,tipoArvore,projecaoSombra,perimetro,gps FROM arvores WHERE especie like '%" + busca + "%'";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selecionar, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        public void Excluir_arvore(string id_arvore, string busca, DataGridView dgvConsultaArvore)
        {
            
                con = Banco.abrir_Conexao();
                string delete = @"DELETE FROM arvores WHERE id_arvore=@Id";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.Parameters.AddWithValue("@Id", id_arvore);
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
                    con.Close();
                }
            
            
        }

        public void Atualizar_datagrid(DataGridView dgvConsultaArvore, string busca)
        {
            con = Banco.abrir_Conexao();
            string Selecionar = @"SELECT * FROM arvores";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Selecionar, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvConsultaArvore.DataSource = dataTable;
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

        public void Atualizar_arvore(string id_rua, string especie, int numeroCasa, string tipoArvore, string sombra, string perimetro, string gps, string id_arvore)
        {
            con = Banco.abrir_Conexao();
            string Update = @"UPDATE arvores SET id_rua=@IdRua, especie=@Especie, numeroCasa=@NumeroCasa, tipoArvore=@TipoArvore, projecaoSombra=@Sombra, perimetro=@Perimetro, gps=@Gps WHERE id_arvore=@IdArvore";
            SqlCommand cmd = new SqlCommand(Update, con);
            cmd.Parameters.AddWithValue("@IdRua", id_rua);
            cmd.Parameters.AddWithValue("@IdArvore", id_arvore);
            cmd.Parameters.AddWithValue("@Especie", especie);
            cmd.Parameters.AddWithValue("@NumeroCasa", numeroCasa);
            cmd.Parameters.AddWithValue("@TipoArvore", tipoArvore);
            cmd.Parameters.AddWithValue("@Sombra", sombra);
            cmd.Parameters.AddWithValue("@Perimetro", perimetro);
            cmd.Parameters.AddWithValue("@Gps", gps);
            cmd.CommandType = CommandType.Text;
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    
                    MessageBox.Show("Registro atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                    
            }
            catch (Exception ex)
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
