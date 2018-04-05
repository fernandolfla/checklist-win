using CheckVTR.BLL;
using CheckVTR.Component;
using CheckVTR.Seguranca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckVTR.Interface
{
    public partial class CheckListFinalizar : Form
    {
        public CheckListFinalizar()
        {
            InitializeComponent();

            txtTatico.Text = Autenticacao.GetNomeUsuario();

        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }




        private void btnProximo_Click(object sender, EventArgs e)
        {

            CheckListBLL BLL = new CheckListBLL();

            if (BLL.Cadastra_Finaliza(txtKmFinal.Text, txtObs.Text))
                MessageBox.Show("CHECKLIST FINALIZADO!!! TKS BOM DESCANSO!!");
            else
                MessageBox.Show("Digite o KM CORRETAMENTE PARA FINALIZAR");

            MensagemErro();

            Application.Restart();

        }
    }
}
