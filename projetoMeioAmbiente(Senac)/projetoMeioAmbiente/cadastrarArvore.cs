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
    public partial class cadastrarArvore : Form
    {
        public cadastrarArvore()
        {
            InitializeComponent();
        }

        string id_ruaEdit;

        private void cadastrarArvore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoProjetoDataSet.ruas' table. You can move, or remove it, as needed.
            this.ruasTableAdapter.Fill(this.bancoProjetoDataSet.ruas);
            // TODO: This line of code loads data into the 'bancoProjetoMADataSet.ruas' table. You can move, or remove it, as needed.
            //this.ruasTableAdapter.Fill(this.bancoProjetoMADataSet.ruas);            

            dgvCadastroArvore.Enabled = true;
            dgvCadastroArvore.DataSource = null;   //impede que o banco carregue todos os dados sem o usuário requisitar         
            txtEspecie.Focus();
        }        

        private void tsbSalvar_Click(object sender, EventArgs e)
        {                        
            if (txtIdRua.Text != string.Empty)
            {
                CodigosGerais c = new CodigosGerais();

                if (c.CampoVazio(txtEspecie, "Espécie", epCadastrarArvore))
                    return;
                if (c.CampoVazio(txtNumeroCasa, "Número da Casa", epCadastrarArvore))
                    return;                
                if (c.CampoVazio(txtProjecaoSombra, "Projeção da Sombra", epCadastrarArvore))
                    return;
                if (c.CampoVazio(txtPerimetro, "Perímetro", epCadastrarArvore))
                    return;
                if (c.CampoVazio(cmbTipoArvore, "Tipo da Árvore", epCadastrarArvore))
                    return;

                classeArvores arvores = new classeArvores();

                int id_rua = Convert.ToInt32(txtIdRua.Text);
                string especie = txtEspecie.Text;
                int numeroCasa = Convert.ToInt32(txtNumeroCasa.Text);
                string tipoArvore = cmbTipoArvore.Text;
                string projecaoSombra = txtProjecaoSombra.Text;
                string perimetro = txtPerimetro.Text;
                string gps = mskGps.Text;

                arvores.Cadastrar_Arvore(id_rua, especie, numeroCasa, tipoArvore, projecaoSombra, perimetro, gps);

                txtIdRua.Clear();
                txtEspecie.Clear();
                txtNumeroCasa.Clear();
                cmbTipoArvore.Text = "";
                txtProjecaoSombra.Clear();
                txtPerimetro.Clear();
                mskGps.Clear();
                txtEspecie.Focus();     
            }
            else if (txtIdRua.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma rua para efetuar o cadastro da árvore", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesquisarRua.Focus();
                return;
            }            
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {            
            txtIdRua.Clear();
            txtEspecie.Clear();
            txtNumeroCasa.Clear();
            cmbTipoArvore.Text = "";
            txtProjecaoSombra.Clear();
            txtPerimetro.Clear();
            mskGps.Clear();            

            epCadastrarArvore.Clear(); // Limpa os ícones do ErrorProvider
        }

        private void txtPesquisarRua_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarRua.Text != string.Empty)
            {
                classeRuas ruas = new classeRuas();
                ruas.Consultar_Rua(dgvCadastroArvore, txtPesquisarRua.Text);
            }
            else
            {
                dgvCadastroArvore.DataSource = null;
            }
            
        }

        private void dgvCadastroArvore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_ruaEdit = dgvCadastroArvore.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtIdRua.Text = id_ruaEdit;
            }                           
        }


        // KeyPress Events

        private void txtProjecaoSombra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && txtProjecaoSombra.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            // Os numero 8, 44 representam as teclas BACKSPACE e VÍRGULA na tabela ASCII
            if (!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void txtPerimetro_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && txtPerimetro.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
            }

            // Os numero 8, 44 representam as teclas BACKSPACE e VÍRGULA na tabela ASCII
            if (!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            } 
        }

        private void txtNumeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
