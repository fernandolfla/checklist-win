using CheckVTR.Interface;
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

namespace CheckVTR
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            CarregaPrincipal();

            if (Autenticacao.GetCodUsuario() == 1 || Autenticacao.GetCodUsuario() == 2 || Autenticacao.GetCodUsuario() == 3)
                LiberaAdmin();

            //INICIAÇÃO DO QUADRO DE AVISOS
            DateTime fim = DateTime.Now;
            if (Autenticacao.GetSituacaoUsuario() == 0 && fim.Day < 01  && fim.Month <= 01)
            {
            
               
                Avisos aviso = new Avisos();
                aviso.ShowDialog();
                
            }

            
            

        }

        //private void btnRecCartaoConvenio_Click(object sender, EventArgs e)
        //{
        //    decimal valor = CalculaRecebimento();
        //    decimal txt = 0;
        //    if (valor > 0)
        //    {
        //        try { txt = Convert.ToDecimal(txtRecCartaoConvenio.Text.Replace("R$", "").Trim()); } catch { txt = 0; }
        //        valor += txt;
        //        txtRecCartaoConvenio.Text = valor.ToString("C2");
        //    }
        //}

        private void LiberaAdmin()
        {
            btnChaves.Enabled = true;
            btnConf.Enabled = true;
            btnTatico.Enabled = true;
            btnVtr.Enabled = true;

        }

        private void CarregaPrincipal()
        {
            txtUsuarioAtivo.Text = Autenticacao.GetNomeUsuario();
            txtServidor.Text = Autenticacao.GetServidor();
            txtSerial.Text = Autenticacao.GetSerial();
            txtVersao.Text = Autenticacao.GetVersao();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            MessageBox.Show("SOMENTE PELO APP ANDROID ");
            //if(Autenticacao.GetSituacaoUsuario() == 0)
            //{
            //    CheckList Tela = new CheckList();
            //    Tela.ShowDialog();
            //}
            //else
            //{
            //    CheckListFinalizar Tela = new CheckListFinalizar();
            //    Tela.ShowDialog();
            //}


            
        }

        private void btnTatico_Click(object sender, EventArgs e)
        {
            CadUsuarios Tela = new CadUsuarios();
            Tela.ShowDialog();
        }

        private void btnVtr_Click(object sender, EventArgs e)
        {
            CadVeiculos Tela = new CadVeiculos();
            Tela.ShowDialog();
        }

        private void btnOleo_Click(object sender, EventArgs e)
        {
            Oleo Tela = new Oleo();
            Tela.ShowDialog();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            Configuracoes Tela = new Configuracoes();
            Tela.ShowDialog();
        }

    

        //private void btnRelatorios_Click(object sender, EventArgs e)
        //{
        //    Relatorios Tela = new Relatorios();
        //    Tela.ShowDialog();
        //}

        private void btnManutenção_Click(object sender, EventArgs e)
        {
            Manutencao Tela = new Manutencao();
            Tela.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChaves_Click(object sender, EventArgs e)
        {
            CadChaves Tela = new CadChaves();
            Tela.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Rel tela = new Rel();
            tela.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            if (Autenticacao.GetTipo() != 3)
            {
                MovCaixa caixa = new MovCaixa();
                caixa.ShowDialog();
            }
            else
                MessageBox.Show("Somente Operadores podem Manusear Caixa, obrigado");
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            CadItens caditens = new CadItens();
            caditens.ShowDialog();

        }
    }
}
