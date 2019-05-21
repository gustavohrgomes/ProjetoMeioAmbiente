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
    public partial class consultaArvore : Form
    {
        public consultaArvore()
        {
            InitializeComponent();
            
        }

        string idArvore_edit = "";
        string idRua_edit = "";
        string especie_edit = "";
        int numeroCasa_edit;
        string tipoArvore_edit = "";
        string sombra_edit;
        string perimetro_edit;
        string gps_edit = "";
        
        private void consultaArvore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoProjetoDataSet.arvores' table. You can move, or remove it, as needed.
            this.arvoresTableAdapter.Fill(this.bancoProjetoDataSet.arvores);
            
            dgvConsultaArvore.DataSource = null;
            
            
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            txtIdArvore.Clear();
            txtIdRua.Clear();
            txtEspecie.Clear();
            txtNumeroCasa.Clear();
            cmbTipoArvore.Text = "";
            txtProjecaoSombra.Clear();
            txtPerimetro.Clear();
            mskGps.Clear();
            txtEspecie.Focus();
            epConsultaArvore.Clear();
            
        }        

        private void txtPesquisaArvore_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaArvore.Text != string.Empty)
            {
                classeArvores arvore = new classeArvores();
                arvore.Consultar_arvores(dgvConsultaArvore, txtPesquisaArvore.Text);
            }
            else if (txtPesquisaArvore.Text == string.Empty)
            {
                dgvConsultaArvore.DataSource = null;
            }
            
        }

        private void dgvConsultaArvore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idArvore_edit = dgvConsultaArvore.Rows[e.RowIndex].Cells[0].Value.ToString();
                idRua_edit = dgvConsultaArvore.Rows[e.RowIndex].Cells[1].Value.ToString();
                especie_edit = dgvConsultaArvore.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                numeroCasa_edit = Convert.ToInt32(dgvConsultaArvore.Rows[e.RowIndex].Cells[3].Value.ToString());
                tipoArvore_edit = dgvConsultaArvore.Rows[e.RowIndex].Cells[4].Value.ToString();
                sombra_edit = dgvConsultaArvore.Rows[e.RowIndex].Cells[5].Value.ToString();
                perimetro_edit = dgvConsultaArvore.Rows[e.RowIndex].Cells[6].Value.ToString();
                gps_edit = dgvConsultaArvore.Rows[e.RowIndex].Cells[7].Value.ToString();

                txtIdArvore.Text = idArvore_edit;
                txtIdRua.Text = idRua_edit;
                txtEspecie.Text = especie_edit;
                txtNumeroCasa.Text = Convert.ToString(numeroCasa_edit);
                cmbTipoArvore.Text = tipoArvore_edit;
                txtProjecaoSombra.Text = sombra_edit;
                txtPerimetro.Text = perimetro_edit;
                mskGps.Text = gps_edit;
            }                        
        }

        private void tsbExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtIdArvore.Text != string.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja excluir o Registro?", "Atenção!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    classeArvores arvores = new classeArvores();

                    arvores.Excluir_arvore(idArvore_edit, txtPesquisaArvore.Text, dgvConsultaArvore);
                    arvores.Atualizar_datagrid(dgvConsultaArvore, txtPesquisaArvore.Text);

                    txtIdArvore.Clear();
                    txtIdRua.Clear();
                    txtEspecie.Clear();
                    txtNumeroCasa.Clear();
                    cmbTipoArvore.Text = "";
                    txtProjecaoSombra.Clear();
                    txtPerimetro.Clear();
                    mskGps.Clear();
                    txtPesquisaArvore.Clear();
                    txtEspecie.Focus();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }            
            else
            {
                MessageBox.Show("Selecione uma árvore para efetuar a exclusão.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void tsbSalvarEdicao_Click(object sender, EventArgs e)
        {
                   
            if (txtIdArvore.Text != string.Empty)
            {
                CodigosGerais c = new CodigosGerais();

                if (c.CampoVazio(txtEspecie, "Especie", epConsultaArvore))
                    return;

                if (c.CampoVazio(txtNumeroCasa, "Nº da Casa", epConsultaArvore))
                    return;

                if (c.CampoVazio(txtProjecaoSombra, "Projeção Sombra", epConsultaArvore))
                    return;

                if (c.CampoVazio(txtPerimetro, "Perímetro", epConsultaArvore))
                    return;

                if (c.CampoVazio(cmbTipoArvore, "Tipo da Árvore", epConsultaArvore))
                    return;

                classeArvores arvore = new classeArvores();                
                arvore.Atualizar_arvore(txtIdRua.Text, txtEspecie.Text, Convert.ToInt32(txtNumeroCasa.Text), cmbTipoArvore.Text, txtProjecaoSombra.Text, txtPerimetro.Text, mskGps.Text, txtIdArvore.Text);

                arvore.Atualizar_datagrid(dgvConsultaArvore, txtPesquisaArvore.Text);

                txtIdArvore.Clear();
                txtIdRua.Clear();
                txtEspecie.Clear();
                txtNumeroCasa.Clear();
                cmbTipoArvore.Text = "";
                txtProjecaoSombra.Clear();
                txtPerimetro.Clear();
                mskGps.Clear();
                txtPesquisaArvore.Clear();
                txtEspecie.Focus();
                
            }
            else if (txtIdArvore.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma árvore para efetuar e salvar as alterações", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPesquisaArvore.Focus();
                return;
            }          
        }

        // KeyPress events - Aceita somente digitos
        private void txtProjecaoSombra_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && txtProjecaoSombra.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
                return;
            }
            
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
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        } 
    }
}
