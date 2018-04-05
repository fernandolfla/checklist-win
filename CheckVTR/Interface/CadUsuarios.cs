using CheckVTR.BLL;
using CheckVTR.Component;
using CheckVTR.Entity;
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
    public partial class CadUsuarios : Form
    {
        public CadUsuarios()
        {
            InitializeComponent();
        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            CadUsuariosBLL BLL = new CadUsuariosBLL();

            usuario = TelaToEntity();
            if (usuario.Id.Length == 0)
            {
                if (BLL.Cadastra(usuario))
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso");
                    LimpaTela();
                }
                else
                {
                    MessageBox.Show("Verifique os campos Obrigatórios");
                    MensagemErro();
                }
            }
            else
                MessageBox.Show("Não é possível editar");

            MensagemErro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CadUsuariosBLL BLL = new CadUsuariosBLL();
            Usuario user = new Usuario();

            user = TelaToEntity();

            user = BLL.BuscaAnt(user);

            if (user != null)
            {
                LimpaTela();
                EntityToTela(user);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();


        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadUsuariosBLL BLL = new CadUsuariosBLL();
            Usuario user = new Usuario();

            user = TelaToEntity();

            user = BLL.BuscaProx(user);

            if (user != null)
            {
                LimpaTela();
                EntityToTela(user);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();


        }


        private Usuario TelaToEntity()
        {
            Usuario user = new Usuario();

            user.Id = txtCodigo.Text;
            user.Nome = txtNome.Text;
            user.Apelido = txtApelido.Text;
            user.Senha = txtSenha.Text;
            if (checkTatico.Checked)
                user.Tipo = 3;
            else
                user.Tipo = 2;

            return user;

        }

        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtApelido.Text = "";
            txtSenha.Text = "";
            checkTatico.Checked = true;
            checkOperador.Checked = false;
        }



        private void EntityToTela(Usuario user)
        {
            txtCodigo.Text = user.Id;
            txtNome.Text = user.Nome;
            txtApelido.Text = user.Apelido;
            if (user.Tipo == 3)
                checkTatico.Checked = true;
            else
                checkTatico.Checked = false;

        }

        private void checkTatico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTatico.Checked)
                checkOperador.Checked = false;
            else
                checkOperador.Checked = true;
        }

        private void checkOperador_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOperador.Checked)
                checkTatico.Checked = false;
            else
                checkTatico.Checked = true;
        }
    }
}
