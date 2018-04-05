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
                                check1.Checked = false;
                                check1.Enabled = false;
                            }
                            else if(km < kmproxima && (kmproxima - km) <= 250){
                                txtOleoVencido.Text = "Óleo Para Vencer! -> " + kmvencido;
                                txtOleoVencido.ForeColor = Color.DarkRed;
                                check1.Checked = false;
                                check1.Enabled = false;
                            }
                            else
                            {
                                txtOleoVencido.Text = "Próx Troca de Óleo -> " + kmproxima;
                                txtOleoVencido.ForeColor = Color.Black;
                                check1.Checked = true;
                                check1.Enabled = true;
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
