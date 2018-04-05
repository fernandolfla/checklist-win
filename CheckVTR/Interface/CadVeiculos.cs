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
    public partial class CadVeiculos : Form
    {
        public CadVeiculos()
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

        private Veiculo TelaToEntity()
        {

            Veiculo c = new Veiculo();
            c.Id = txtId.Text;
            c.Placa = txtPlacaVTR.Text;
            c.Modelo = txtModelo.Text;
            c.Km = txtKM.Text;
            c.ProxTroca = txtProxTroca.Text;
            c.UltimaTroca = txtUltimaTroca.Text;
            c.TrocaPadrao = txtTrocaPadrao.Text;

            return c;
        }
        private void LimpaTela()
        {
            txtPlacaVTR.Text = "";
            txtModelo.Text = "";
            txtKM.Text = "";
            txtProxTroca.Text = "";
            txtUltimaTroca.Text = "";
            txtTrocaPadrao.Text = "";
            txtId.Text = "";
        }
        private void EntityToTela(Veiculo c)
        {
            txtPlacaVTR.Text = c.Placa;
            txtModelo.Text = c.Modelo;
            txtKM.Text = c.Km;
            txtProxTroca.Text = c.ProxTroca;
            txtUltimaTroca.Text = c.UltimaTroca;
            txtTrocaPadrao.Text = c.TrocaPadrao;
            txtId.Text = c.Id;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Veiculo c = new Veiculo();
           CadVeiculosBLL BLL = new CadVeiculosBLL();

            c = TelaToEntity();

            if (BLL.Cadastra(c))
            {
                MessageBox.Show("Cadastro Realizado com Sucesso");
                LimpaTela();
            }
            else
            {
                MessageBox.Show("Verifique os campos Obrigatórios");
                MensagemErro();
            }

            MensagemErro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CadVeiculosBLL BLL = new CadVeiculosBLL();
            Veiculo c = new Veiculo();

            c = TelaToEntity();

            c = BLL.BuscaAnt(c);

            if (c != null)
            {
                LimpaTela();
                EntityToTela(c);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadVeiculosBLL BLL = new CadVeiculosBLL();
            Veiculo c = new Veiculo();

            c = TelaToEntity();

            c = BLL.BuscaProx(c);

            if (c != null)
            {
                LimpaTela();
                EntityToTela(c);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Realmente deseja Excluir? A Exclusão pode ocasionar inconsistencia no Banco de Dados! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                CadVeiculosBLL BLL = new CadVeiculosBLL();
                Veiculo c = new Veiculo();
                c = TelaToEntity();
                if (BLL.Apaga(c.Placa))
                {
                    MessageBox.Show("Deletado com Sucesso");
                }
                else MessageBox.Show("O Veiculo não poderá ser excluido, ou Selecione um cliente Válido!");

                LimpaTela();
                MensagemErro();

            }
        }
    }
}
