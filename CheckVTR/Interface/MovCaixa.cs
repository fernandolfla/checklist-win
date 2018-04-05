using CheckVTR.BLL;
using CheckVTR.Component;
using CheckVTR.Entity;
using CheckVTR.Seguranca;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CheckVTR.Interface
{
    public partial class MovCaixa : Form
    {
        private Caixa_Situacao situacao ;
        
        public MovCaixa()
        {
            InitializeComponent();

            AplicarEventos(txtValorCaixa);
            AplicarEventos(txtValorAbertura);

            Inicializa();
            MensagemErro();

        }
        public void Inicializa()
        {
            MovimentoBLL BLL = new MovimentoBLL();
            situacao = BLL.BuscaCaixa_Situacao(Autenticacao.GetCaixa_Situacao().Id);
            EntityToTela(situacao);
            if (situacao != null)
            {
                Autenticacao.SetCaixa_Situacao(situacao);
                EntityToTela(situacao);
            }
        }
        private void TelaToEntity()
        {
            if (situacao == null)
            {
                situacao = new Caixa_Situacao();
            }

            //situacao.Situacao_Id = 0;
            try { situacao.ValorInicial = Convert.ToDouble(txtValorAbertura.Text.Replace("R$", "").Trim()); }
            catch { situacao.ValorInicial = 0; }
        }
        private void EntityToTela(Caixa_Situacao c)
        {
            if (c != null)
            {
                txtSituacao.Text = c.Situacao_Nome;
                if (c.Situacao_Id == 0)
                {
                    CaixaFechado();
                }
                else
                {
                    CaixaAberto();
                    txtValorAbertura.Text = c.ValorInicial.ToString("C2");
                    txtValorCaixa.Text = c.TotalDinheiro.ToString("C2");
                }
            }
            else
            {
                txtSituacao.Text = "Fechado";
                CaixaFechado();
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
        //EVENTOS DE CAMPOS DE DINHEIRO

        private void CaixaAberto()
        {
            btnFechaCaixa.Enabled = true;
            btnAbrirCaixa.Enabled = false;
            btnEntradas.Enabled = true;
            btnSaidas.Enabled = true;
            txtValorAbertura.Enabled = false;
            
        }
        private void CaixaFechado()
        {
            btnFechaCaixa.Enabled = false;
            btnAbrirCaixa.Enabled = true;
            btnEntradas.Enabled = false;
            btnSaidas.Enabled = false;
            txtValorAbertura.Text = "0";
            txtValorCaixa.Text = "0";
            txtValorAbertura.Enabled = true;
        }

        public void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }
        private void ApenasNumerico(TextBox txt)
        {
            txt.KeyPress += ApenasValorNumerico;
            txt.Leave += RetornarMascaraNumero;
            //#################################################################################
        }
        private void RetornarMascaraNumero(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("0");
            }
            catch (Exception) { }
        }
        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            catch (Exception) { }
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        //EVENTOS DE CAMPOS DE DINHEIRO FIM
        private void btnSaidas_Click(object sender, EventArgs e)
        {
            MovSaidas saida = new MovSaidas(this);
            saida.ShowDialog();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            MovEntradas entrada = new MovEntradas(this);
            entrada.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechaCaixa_Click(object sender, EventArgs e)
        {
            MovimentoBLL BLL = new MovimentoBLL();
            TelaToEntity();
            if(situacao != null)
                if (BLL.Fecha(situacao))
                {
                    CaixaFechado();
                    Inicializa();
                    MessageBox.Show("Caixa Encerrado com Sucesso");
                }
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            TelaToEntity();
            if(Autenticacao.GetCaixa_Situacao().Situacao_Id == 0)
            {
                MovimentoBLL BLL = new MovimentoBLL();
                if (situacao != null)
                    if (BLL.Abre(situacao))
                    {
                        CaixaAberto();
                        Inicializa();
                        MessageBox.Show("Caixa Aberto com Sucesso");
                    }
            }
        }

    }
}
