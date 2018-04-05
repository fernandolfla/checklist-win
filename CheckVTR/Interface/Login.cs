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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


            //txtServidor.Text = "CONECTADO";

            Splash splash = new Splash(this);
            splash.ShowDialog();
        }

        private bool VerificaServidor()
        {
            LoginBLL BLL = new LoginBLL();
            if(BLL.VerificaServidor())
                return true;
            return false;
        }


        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }
        private bool usuario_ok = false;

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginBLL BLL = new LoginBLL();

            int resposta = BLL.Logar(txtCodUsuario.Text, txtSenha.Text);

            switch (resposta)
            {
                case 0:
                    MessageBox.Show("Usuario Invalido");
                    break;
                case 1:
                    DialogResult = DialogResult.OK;
                    break;
                case 2:
                    MessageBox.Show("Senha Invalida");
                    break;
                case 3:
                    MessageBox.Show("Senha Incorreta");
                    break;
                default:
                    MessageBox.Show("Ocorreu erros ao tentar logar, contacte o administrador");
                    break;
            }


            MensagemErro();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCodUsuario_Leave(object sender, EventArgs e)
        {
            LoginBLL BLL = new LoginBLL();
            txtNomeUsuario.Text = BLL.VerificaUsuario(txtCodUsuario.Text);

            if (!txtNomeUsuario.Text.Equals("") && txtNomeUsuario.Text.Length > 1)
                usuario_ok = true;
        }

        private void txtCodUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnEntrar_Click(1, new EventArgs());
            }
        }
    }
}
