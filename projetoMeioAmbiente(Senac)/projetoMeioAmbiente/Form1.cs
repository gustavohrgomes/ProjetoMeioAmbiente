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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmiCadastrarRua_Click(object sender, EventArgs e)
        {
            cadastrarRua rua = new cadastrarRua();
            rua.ShowDialog();
        }

        private void tsmiCadastrarArvore_Click(object sender, EventArgs e)
        {
            cadastrarArvore arvore = new cadastrarArvore();
            arvore.ShowDialog();
        }

        private void tsmiConsultaArvore_Click(object sender, EventArgs e)
        {
            consultaArvore consultaArvore = new consultaArvore();
            consultaArvore.ShowDialog();
        }

        private void tsmiConsultaRua_Click(object sender, EventArgs e)
        {
            consultaRua consultaRua = new consultaRua();
            consultaRua.ShowDialog();
        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo sair do aplicativo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }           
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
