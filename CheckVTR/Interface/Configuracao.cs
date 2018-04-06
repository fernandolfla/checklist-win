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
    public partial class Configuracao : Form
    {
        private Entity.Configuracao conf = new Entity.Configuracao();
        public Configuracao()
        {
            InitializeComponent();

            ConfiguracoesBLL BLL = new ConfiguracoesBLL();

            conf = BLL.Busca();

            if(conf != null)
            {
                EntityToTela(conf);
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

        private Entity.Configuracao TelaToEntity()
        {
            Entity.Configuracao c = new Entity.Configuracao();
            c.Razao = txtRazao.Text;
            c.Fantasia = txtFantasia.Text;
            c.CNPJ = txtCNPJ.Text;
            c.Endereco = txtEndereco.Text;
            c.Numero = txtNumero.Text;
            c.Telefone = txtTelefone.Text;
            c.Responsavel = txtResponsavel.Text;
            c.QtdVeiculos = txtQtdVeiculos.Text;
            c.QtdAreas = txtQtdAreas.Text;
            
            return c;
        }

        private void EntityToTela(Entity.Configuracao c)
        {
            txtRazao.Text = c.Razao;
            txtFantasia.Text = c.Fantasia ;
            txtCNPJ.Text = c.CNPJ;
            txtEndereco.Text = c.Endereco;
            txtNumero.Text = c.Numero;
            txtTelefone.Text = c.Telefone;
            txtResponsavel.Text = c.Responsavel;
            txtQtdVeiculos.Text = c.QtdVeiculos;
            txtQtdAreas.Text = c.QtdAreas;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Entity.Configuracao co = new Entity.Configuracao();
            ConfiguracoesBLL BLL = new ConfiguracoesBLL();

            co = TelaToEntity();

            if (BLL.Atualiza(co))
            {
                MessageBox.Show("Sistema Atualizado");
            }
            else
            {
                MessageBox.Show("Verifique os campos Obrigatórios");
                MensagemErro();
            }

            MensagemErro();




        }
    }
}
