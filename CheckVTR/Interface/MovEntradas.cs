using CheckVTR.BLL;
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
    public partial class MovEntradas : Form
    {
        MovCaixa m;
        public MovEntradas(MovCaixa mv)
        {
            InitializeComponent();

            AplicarEventos(txtValor);

            m = mv;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            MovimentoBLL BLL = new MovimentoBLL();
            if (BLL.Cadastra(TelaToEntity()))
            {
                MessageBox.Show("Entrada Cadastrada com sucesso");
                LimpaTela();
            }
            else
                MessageBox.Show("Verifique os campos obrigatorios");
            this.Cursor = Cursors.Default;


        }


        private Caixa_Movimento TelaToEntity()
        {
            Caixa_Movimento cx = new Caixa_Movimento();
            cx.Descricao = txtDescricao.Text;
            cx.Autorizado = txtAutorizado.Text;
            try { cx.Valor = Convert.ToDouble(txtValor.Text.Replace("R$", "").Trim()); }
            catch { cx.Valor = 0; }
            cx.TipoMovimento = "Entrada";
            cx.SaidaEntrada = 2;
            cx.Abastecimento = 0;

            return cx;
        }

        private void LimpaTela()
        {
            txtDescricao.Text = ""; ;
            txtAutorizado.Text = ""; ;
            txtValor.Text = "";           
        }


        //EVENTOS DE CAMPOS DE DINHEIRO
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AoSair(object sender, FormClosedEventArgs e)
        {
            m.Inicializa();
        }


        //EVENTOS DE CAMPOS DE DINHEIRO FIM
    }
}
