using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoMeioAmbiente
{
    public partial class cadastrarRua : Form
    {
        public cadastrarRua()
        {
            InitializeComponent();
        }

        private void cadastrarRua_Load(object sender, EventArgs e)
        {
            txtEndereco.Focus();
        }                

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            CodigosGerais c = new CodigosGerais();

            int verifica = 0;
           
            //Validação Endereço
            if (c.CampoVazio(txtEndereco, "Endereço", epCadastrarRua))              
                return;
                                  
            // Validação Bairro
            if (c.CampoVazio(txtBairro, "Bairro", epCadastrarRua))                                           
                return;
                        
            // Validação Cidade
            if (c.CampoVazio(txtCidade, "Cidade", epCadastrarRua))                                            
                return;
                        
            // Validação Quantidade Casas
            if (c.CampoVazio(txtQntdCasas, "Quantidade de Casas", epCadastrarRua))                                            
                return;
                        
            // Validação Quantidade Árvores
            if (c.CampoVazio(txtQntdArvores, "Quantidade de Árvores", epCadastrarRua))                                           
                return;
                       
            if (verifica == 0)
            {
                classeRuas rua = new classeRuas();

                string endereco = txtEndereco.Text;
                string cep = mskCep.Text;
                string bairro = txtBairro.Text;
                string cidade = txtCidade.Text;
                int qntdCasas = Convert.ToInt32(txtQntdCasas.Text);
                int qntdArvores = Convert.ToInt32(txtQntdArvores.Text);

                rua.Cadastrar_rua(endereco, cep, bairro, cidade, qntdCasas, qntdArvores);

                txtEndereco.Clear();
                mskCep.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtQntdCasas.Clear();
                txtQntdArvores.Clear();
                txtEndereco.Focus();
            }            
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            txtEndereco.Focus();
            txtEndereco.Clear();
            mskCep.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtQntdCasas.Clear();
            txtQntdArvores.Clear();
            epCadastrarRua.Clear(); // Limpa os ícones do ErrorProvider
        }

        // KeyPress Events
        private void txtQntdCasas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // O numero 8 representam a tecla BACKSPACE na tabela ASCII
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQntdArvores_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // O numero 8 representam a tecla BACKSPACE na tabela ASCII
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }        
    }
}
