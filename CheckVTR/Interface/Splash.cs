using CheckVTR.BLL;
using CheckVTR.Component;
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
    public partial class Splash : Form
    {
        private Login login;
        private bool sair = false;
        public Splash(Login login)
        {
            this.login = login;

            InitializeComponent();

            VerificaServidor();

            var task = Task.Factory.StartNew(() =>
            {
                if (VerificaServidor())
                {
                    MensagemErro();
                    login.txtServidor.Text = "CONECTADO";
                    sair = true;
                }

                else
                {
                    MensagemErro();
                    login.txtServidor.Text = "ERRO FATAL";
                }

            });
            task.ContinueWith(
            t =>
            {
                MensagemErro();
            }, TaskScheduler.FromCurrentSynchronizationContext());


        }

        private bool VerificaServidor()
        {
            LoginBLL BLL = new LoginBLL();
            if (BLL.VerificaServidor())
                return true;
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pbCarrega.Value < 100)
            {
                pbCarrega.Value = pbCarrega.Value + 2;
                if (sair && pbCarrega.Value > 50)
                    this.Close();
            }else
                    {
                timer1.Enabled = false;
                this.Close();
            }



        }


        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }
    }
}
