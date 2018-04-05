using CheckVTR.BLL;
using CheckVTR.Component;
using CheckVTR.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckVTR.Interface
{
    public partial class MovSaidas : Form
    {
        Bitmap bmp;
        private List<Veiculo> veiculos = new List<Veiculo>();
        MovCaixa m;
        public MovSaidas(MovCaixa mv)
        {

            InitializeComponent();

            m = mv;

            ApenasNumerico(txtCupom);
            ApenasNumerico(txtKM);
            AplicarEventos(txtValor);

            OleoBLL BLL = new OleoBLL();

            veiculos = BLL.ListaVeiculos();

            if (veiculos != null)
            {
                foreach (Veiculo p in veiculos)
                {

                    comboPlaca.Items.Add(p.Placa);

                }
            }

            MensagemErro();



        }

        private Caixa_Movimento TelaToEntity()
        {
            Caixa_Movimento cx = new Caixa_Movimento();
            if (checkAbastecimento.Checked)
                cx.Abastecimento = 1;
            else
                cx.Abastecimento = 0;

            cx.Numcupom = txtCupom.Text;
            cx.Tatico = txtTatico.Text;
            cx.Placa = comboPlaca.Text;
            cx.KM = txtKM.Text;
            cx.Descricao = txtDescricao.Text;
            cx.Autorizado = txtAutorizado.Text;         
            try { cx.Valor = Convert.ToDouble(txtValor.Text.Replace("R$", "").Trim()); }
            catch { cx.Valor = 0; }
            cx.TipoMovimento = "Saida";
            cx.SaidaEntrada = 1;
            if(bmp != null)
                cx.Imagem = imageToByteArray(bmp);


            return cx;
        }

        private void LimpaTela()
        {
            txtCupom.Text = ""; ;
            txtTatico.Text = ""; ;
            comboPlaca.Text = ""; ;
            txtKM.Text = ""; ;
            txtDescricao.Text = ""; ;
            txtAutorizado.Text = ""; ;
            txtValor.Text = "";
            checkAbastecimento.Checked = true;
            checkOutros.Checked = false;
            bmp = null;
            pictureComprovante.Dispose();
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
            this.Cursor = Cursors.AppStarting;
            MovimentoBLL BLL = new MovimentoBLL();
            if (BLL.Cadastra(TelaToEntity()))
            {
                MessageBox.Show("Saída Cadastrada com sucesso");
                LimpaTela();
            }
            else
                MessageBox.Show("Verifique os campos obrigatorios");
            this.Cursor = Cursors.Default;
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
        //EVENTOS DE CAMPOS DE DINHEIRO FIM
        private void checkAbastecimento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAbastecimento.Checked)
                Abastecimento_Checked();
            else
                Abastecimento_NoChecked();
                
        }
        private void Abastecimento_Checked()
        {
            txtKM.Enabled = true;
            comboPlaca.Enabled = true;
            checkOutros.Checked = false;
            checkAbastecimento.Checked = true;
        }
        private void Abastecimento_NoChecked()
        {
            txtKM.Enabled = false;
            comboPlaca.Enabled = false;
            checkOutros.Checked = true;
            checkAbastecimento.Checked = false;
        }
        private void checkOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOutros.Checked)
                Abastecimento_NoChecked();
            else
                Abastecimento_Checked();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Copiar Imagem para local e jogar para imagem 

        
            OpenFileDialog BuscaIMG = new OpenFileDialog();
            BuscaIMG.Filter = "Imagem|*.jpg;*.png;*.png";
            try
            {
                if (BuscaIMG.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(BuscaIMG.FileName);

                    string origem = BuscaIMG.FileName;
                    bmp = new Bitmap(origem);

                    pictureComprovante.Image = bmp;




                    //string destino = string.Concat(Environment.CurrentDirectory + "\\Imagens\\", System.IO.Path.GetFileName(origem));

                    //System.IO.File.Delete(destino);
                    //System.IO.File.Copy(origem, destino);

                    //ResizeIMG.ResizeImage(destino, destino, 720, 1080);
                    //salvar Destino no banco =)
                    sr.Close();
                    //pictureProduto.ImageLocation = destino;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A imagem já existe na pasta com o mesmo nome, abra novamente e mude o nome. ERRO = " + ex);
            }




        }
        public byte[] imageToByteArray(Bitmap imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AoSair(object sender, FormClosedEventArgs e)
        {

            m.Inicializa();

        }
    }
}
