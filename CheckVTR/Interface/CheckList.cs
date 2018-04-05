using CheckVTR.BLL;
using CheckVTR.Component;
using CheckVTR.Entity;
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
    public partial class CheckList : Form
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private List<Veiculo> veiculosB = new List<Veiculo>();
        public CheckList()
        {
            InitializeComponent();



            OleoBLL BLL = new OleoBLL();

            veiculos = BLL.ListaVeiculos();

            if (veiculos != null)
            {
                foreach (Veiculo p in veiculos)
                {
                    if (p.Situacao == 0)
                    {
                        comboPlaca.Items.Add(p.Placa);
                        veiculosB.Add(p);
                    }
                }
            }


            dateTimeInicio.Value = DateTime.Now;

            txtTatico.Text = Autenticacao.GetApelido();

            MensagemErro();
        }

        private void AtualizaTextOleo()
        {
            int km = 0;
            int kmvencido = 0;
            int kmproxima = 0;
            try
            {
                if (veiculosB != null)
                {
                    foreach (Veiculo p in veiculosB)
                    {
                        if (p.Placa.Equals(comboPlaca.SelectedItem.ToString()))
                        {
                            try { kmproxima = Convert.ToInt32(p.ProxTroca); } catch { }
                            try { km = Convert.ToInt32(p.Km); } catch { }
                            try { kmvencido = Convert.ToInt32(p.ProxTroca); } catch { }

                            if (km >= kmproxima)
                            {
                                txtOleoVencido.Text = "Óleo Vencido!! -> " + kmvencido;
                                txtOleoVencido.ForeColor = Color.Red;
                                checkOleo.Checked = false;
                                checkOleo.Enabled = false;
                            }
                            else if(km < kmproxima && (kmproxima - km) <= 250){
                                txtOleoVencido.Text = "Óleo Para Vencer! -> " + kmvencido;
                                txtOleoVencido.ForeColor = Color.DarkRed;
                                checkOleo.Checked = false;
                                checkOleo.Enabled = false;
                            }
                            else
                            {
                                txtOleoVencido.Text = "Próx Troca de Óleo -> " + kmproxima;
                                txtOleoVencido.ForeColor = Color.Black;
                                checkOleo.Checked = true;
                                checkOleo.Enabled = true;
                            }
                        }                         
                    }
                }
            }
            catch (Exception) { }
        }


        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private Check TelaToEntity()
        {
            Check c = new Check();
            c.CodTatico = Autenticacao.GetCodUsuario().ToString();
            c.Tatico = Autenticacao.GetNomeUsuario();
            c.Area = comboArea.Text;
            c.Placa = comboPlaca.Text;
            c.KmInicial = txtKmInicial.Text;
            c.Obs = txtObs.Text;
            if (string.IsNullOrEmpty(c.Obs))
                c.Obs = "Plantão S.A.";

            if (checkOleo.Checked)
                c.Oleo = 1;
            else
                c.Oleo = 0;

            if (checkCombustivel.Checked)
                c.Combustivel = 1;
            else
                c.Combustivel = 0;

            if (checkP90.Checked)
                c.P90 = 1;
            else
                c.P90 = 0;

            if (checkRetrovisores.Checked)
                c.Retrovisores = 1;
            else
                c.Retrovisores = 0;

            if (checkFarois.Checked)
                c.Farois = 1;
            else
                c.Farois = 0;

            if (checkFerramentas.Checked)
                c.Ferramentas = 1;
            else
                c.Ferramentas = 0;

            if (checkPneu.Checked)
                c.Pneu = 1;
            else
                c.Pneu = 0;

            if (checkLanternas.Checked)
                c.Lanternas = 1;
            else
                c.Lanternas = 0;

            if (checkDocumento.Checked)
                c.Documento = 1;
            else
                c.Documento = 0;

            if (checkChave.Checked)
                c.Chave = 1;
            else
                c.Chave = 0;

            if (checkGPS.Checked)
                c.suporte = 1;
            else
                c.suporte = 0;

            if (checkCarregador.Checked)
                c.carregador = 1;
            else
                c.carregador = 0;

            if (checkPintura.Checked)
                c.Pintura = 1;
            else
                c.Pintura = 0;


            return c;
        }


        private bool verificaTela()
        {
            if (comboArea.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione Sua Área!!");
                return false;
            }          
            if (comboPlaca.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione Uma VTR para Assumir!!");
                return false;
            }
            if (string.IsNullOrEmpty(txtKmInicial.Text))
            {
                MessageBox.Show("Digite o KM da VTR");
                return false;
            }

            return true;
        }




        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (verificaTela())
            {
                CheckList_Chaves Tela = new CheckList_Chaves(TelaToEntity());
                Tela.ShowDialog();
            }
        }

        private void comboPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTextOleo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
