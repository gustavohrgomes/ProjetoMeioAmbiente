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

namespace projetoMeioAmbiente
{
    public partial class consultaRua : Form
    {
        public consultaRua()
        {
            InitializeComponent();
            txtEndereco.Focus();
        }

        string idRua_edit = "";
        string endereco_edit = "";
        string cep_edit = "";
        string bairro_edit = "";
        string cidade_edit = "";
        int qntdCasas_edit;
        int qntdArvores_edit;


        private void consultaRua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoProjetoDataSet.ruas' table. You can move, or remove it, as needed.
            this.ruasTableAdapter.Fill(this.bancoProjetoDataSet.ruas);

            dgvConsultaRua.DataSource = null; // impede que o banco carregue todos os dados sem o usuário requisitar



        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            txtIdRua.Clear();
            txtEndereco.Clear();
            mskCep.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtQntdCasas.Clear();
            txtQntdArvores.Clear();
            txtEndereco.Focus();
            epConsultarRua.Clear();
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {

            if (txtIdRua.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir o Registro?", "Atenção!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    classeRuas rua = new classeRuas();
                    rua.Excluir_Rua(idRua_edit, txtPesquisarRuaConsulta.Text, dgvConsultaRua);

                    txtIdRua.Clear();
                    txtEndereco.Clear();
                    mskCep.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    txtQntdCasas.Clear();
                    txtQntdArvores.Clear();
                    txtEndereco.Focus();
                    txtPesquisarRuaConsulta.Clear();
                    epConsultarRua.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma rua para excluir.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txtPesquisarRuaConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarRuaConsulta.Text != string.Empty)
            {
                classeRuas rua = new classeRuas();
                rua.Consultar_Rua(dgvConsultaRua, txtPesquisarRuaConsulta.Text);
            }
            else if (txtPesquisarRuaConsulta.Text == string.Empty)
            {
                dgvConsultaRua.DataSource = null;
            }

        }

        private void dgvConsultaRua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idRua_edit = dgvConsultaRua.Rows[e.RowIndex].Cells[0].Value.ToString();
                endereco_edit = dgvConsultaRua.Rows[e.RowIndex].Cells[1].Value.ToString();
                cep_edit = dgvConsultaRua.Rows[e.RowIndex].Cells[2].Value.ToString();
                bairro_edit = dgvConsultaRua.Rows[e.RowIndex].Cells[3].Value.ToString();
                cidade_edit = dgvConsultaRua.Rows[e.RowIndex].Cells[4].Value.ToString();
                qntdCasas_edit = Convert.ToInt32(dgvConsultaRua.Rows[e.RowIndex].Cells[5].Value.ToString());
                qntdArvores_edit = Convert.ToInt32(dgvConsultaRua.Rows[e.RowIndex].Cells[6].Value.ToString());


                txtIdRua.Text = idRua_edit;
                txtEndereco.Text = endereco_edit;
                mskCep.Text = cep_edit;
                txtBairro.Text = bairro_edit;
                txtCidade.Text = cidade_edit;
                txtQntdCasas.Text = Convert.ToString(qntdCasas_edit);
                txtQntdArvores.Text = Convert.ToString(qntdArvores_edit);
            }
        }

        private void tsbSalvarEdicao_Click(object sender, EventArgs e)
        {

            if (txtIdRua.Text != string.Empty)
            {
                CodigosGerais c = new CodigosGerais();

                if (c.CampoVazio(txtEndereco, "Endereço", epConsultarRua))
                    return;
                if (c.CampoVazio(txtBairro, "Bairro", epConsultarRua))
                    return;
                if (c.CampoVazio(txtCidade, "Cidade", epConsultarRua))
                    return;
                if (c.CampoVazio(txtQntdCasas, "Quantidade de Casas", epConsultarRua))
                    return;
                if (c.CampoVazio(txtQntdArvores, "Quantidade de Árvores", epConsultarRua))
                    return;

                classeRuas ruas = new classeRuas();
                ruas.Atualizar_rua(txtEndereco.Text, mskCep.Text, txtBairro.Text, txtCidade.Text, Convert.ToInt32(txtQntdCasas.Text), Convert.ToInt32(txtQntdArvores.Text), Convert.ToInt32(txtIdRua.Text));
                ruas.Atualizar_datagrid(dgvConsultaRua, txtPesquisarRuaConsulta.Text);

                txtIdRua.Clear();
                txtEndereco.Clear();
                mskCep.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtQntdCasas.Clear();
                txtQntdArvores.Clear();
                txtPesquisarRuaConsulta.Clear();
                txtEndereco.Focus();
                epConsultarRua.Clear();


            }
            else
            {
                MessageBox.Show("Selecione uma rua para efetuar e salvar as alterações", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesquisarRuaConsulta.Focus();
                return;
            }


        }

        // KeyPress events - Aceita somente digitos
        private void txtQntdCasas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQntdArvores_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }
    }
}
