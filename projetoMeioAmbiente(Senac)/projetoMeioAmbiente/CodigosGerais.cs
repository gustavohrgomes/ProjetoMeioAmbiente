using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace projetoMeioAmbiente
{
    public class CodigosGerais
    {
        public bool CampoVazio(Control controle, string campo, ErrorProvider erro)
        {
            erro.Clear();
            if (controle.Text == string.Empty )
            {
                erro.SetError(controle, "Obrigatório!");
                MessageBox.Show("O campo " + campo + " é obrigatório!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MostraMsg("3");
                controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MostraMsg(string tipo)
        {
            // 1 - OK
            // 2 - Erro
            // 3 - Pergunta
            frmAviso frm = new frmAviso();
            if (tipo == "1")
            {
                frm.imgOk.Visible = true;
                frm.imgError.Visible = false;
                frm.imgQuestionMark.Visible = false;
                frm.BackColor = Color.LightGreen;
                frm.ShowDialog();
            }
            if (tipo == "2")
            {
                frm.imgOk.Visible = false;
                frm.imgError.Visible = true;
                frm.imgQuestionMark.Visible = false;
                frm.BackColor = Color.SandyBrown;
                frm.ShowDialog();
            }
            if (tipo == "3")
            {
                frm.imgOk.Visible = false;
                frm.imgError.Visible = false;
                frm.imgQuestionMark.Visible = true;
                frm.BackColor = Color.AliceBlue;
                frm.ShowDialog();
            }
        }               
    }


}
