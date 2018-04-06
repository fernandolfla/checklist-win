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
        private List<Item> item = new List<Item>();
        //private List<Item> item_checados = new List<Item>();

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

            CadItemBLL BLL2 = new CadItemBLL();
            item = BLL2.ListaItem();


            if(item != null)
            {
                check1.Visible = true;
                check1.Text = item[0].Nome;

                if(item.Count > 1)
                {
                    check2.Visible = true;
                    check2.Text = item[1].Nome;
                }
                if (item.Count > 2)
                {
                    check3.Visible = true;
                    check3.Text = item[2].Nome;
                }
                if (item.Count > 3)
                {
                    check4.Visible = true;
                    check4.Text = item[3].Nome;
                }
                if (item.Count > 4)
                {
                    check5.Visible = true;
                    check5.Text = item[4].Nome;
                }
                if (item.Count > 5)
                {
                    check6.Visible = true;
                    check6.Text = item[5].Nome;
                }
                if (item.Count > 6)
                {
                    check7.Visible = true;
                    check7.Text = item[6].Nome;
                }
                if (item.Count > 7)
                {
                    check8.Visible = true;
                    check8.Text = item[7].Nome;
                }
                if (item.Count > 8)
                {
                    check9.Visible = true;
                    check9.Text = item[8].Nome;
                }
                if (item.Count > 9)
                {
                    check10.Visible = true;
                    check10.Text = item[9].Nome;
                }
                if (item.Count > 10)
                {
                    check11.Visible = true;
                    check11.Text = item[10].Nome;
                }
                if (item.Count > 11)
                {
                    check12.Visible = true;
                    check12.Text = item[11].Nome;
                }
                if (item.Count > 12)
                {
                    check13.Visible = true;
                    check13.Text = item[12].Nome;
                }
                if (item.Count > 13)
                {
                    check14.Visible = true;
                    check14.Text = item[13].Nome;
                }
                if (item.Count > 14)
                {
                    check15.Visible = true;
                    check15.Text = item[14].Nome;
                }
                if (item.Count > 15)
                {
                    check16.Visible = true;
                    check16.Text = item[15].Nome;
                }
                if (item.Count > 16)
                {
                    check17.Visible = true;
                    check17.Text = item[16].Nome;
                }
                if (item.Count > 17)
                {
                    check18.Visible = true;
                    check18.Text = item[17].Nome;
                }
                if (item.Count > 18)
                {
                    check19.Visible = true;
                    check19.Text = item[18].Nome;
                }
                if (item.Count > 19)
                {
                    check20.Visible = true;
                    check20.Text = item[19].Nome;
                }
                if (item.Count > 20)
                {
                    check21.Visible = true;
                    check21.Text = item[20].Nome;
                }
                if (item.Count > 21)
                {
                    check22.Visible = true;
                    check22.Text = item[21].Nome;
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

            c.Combustivel = trackBarCombustivel.Value.ToString();

            VerificaCheck();

            c.Itens = item;

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

        private void VerificaCheck()
        {
            if(check1.Visible)
            {
                if (check1.Checked)
                    item[0].Check = 1;
                else
                    item[0].Check = 0;
            }
            if (check2.Visible)
            {
                if (check2.Checked)
                    item[1].Check = 1;
                else
                    item[1].Check = 0;
            }
            if (check3.Visible)
            {
                if (check3.Checked)
                    item[2].Check = 1;
                else
                    item[2].Check = 0;
            }
            if (check4.Visible)
            {
                if (check4.Checked)
                    item[3].Check = 1;
                else
                    item[3].Check = 0;
            }
            if (check5.Visible)
            {
                if (check5.Checked)
                    item[4].Check = 1;
                else
                    item[4].Check = 0;
            }
            if (check6.Visible)
            {
                if (check6.Checked)
                    item[5].Check = 1;
                else
                    item[5].Check = 0;
            }
            if (check7.Visible)
            {
                if (check7.Checked)
                    item[6].Check = 1;
                else
                    item[6].Check = 0;
            }
            if (check8.Visible)
            {
                if (check8.Checked)
                    item[7].Check = 1;
                else
                    item[7].Check = 0;
            }
            if (check9.Visible)
            {
                if (check9.Checked)
                    item[8].Check = 1;
                else
                    item[8].Check = 0;
            }
            if (check10.Visible)
            {
                if (check10.Checked)
                    item[9].Check = 1;
                else
                    item[9].Check = 0;
            }
            if (check11.Visible)
            {
                if (check11.Checked)
                    item[10].Check = 1;
                else
                    item[10].Check = 0;
            }
            if (check12.Visible)
            {
                if (check12.Checked)
                    item[11].Check = 1;
                else
                    item[11].Check = 0;
            }
            if (check13.Visible)
            {
                if (check13.Checked)
                    item[12].Check = 1;
                else
                    item[12].Check = 0;
            }
            if (check14.Visible)
            {
                if (check14.Checked)
                    item[13].Check = 1;
                else
                    item[13].Check = 0;
            }
            if (check15.Visible)
            {
                if (check15.Checked)
                    item[14].Check = 1;
                else
                    item[14].Check = 0;
            }
            if (check16.Visible)
            {
                if (check16.Checked)
                    item[15].Check = 1;
                else
                    item[15].Check = 0;
            }
            if (check17.Visible)
            {
                if (check17.Checked)
                    item[16].Check = 1;
                else
                    item[16].Check = 0;
            }
            if (check18.Visible)
            {
                if (check18.Checked)
                    item[17].Check = 1;
                else
                    item[17].Check = 0;
            }
            if (check19.Visible)
            {
                if (check19.Checked)
                    item[18].Check = 1;
                else
                    item[18].Check = 0;
            }
            if (check20.Visible)
            {
                if (check20.Checked)
                    item[19].Check = 1;
                else
                    item[19].Check = 0;
            }
            if (check21.Visible)
            {
                if (check21.Checked)
                    item[20].Check = 1;
                else
                    item[20].Check = 0;
            }
            if (check22.Visible)
            {
                if (check22.Checked)
                    item[21].Check = 1;
                else
                    item[21].Check = 0;
            }
        }


        /*
          private void VerificaCheck()
        {

            if (checkBox1.Visible)
            {
                if (checkBox1.Checked)
                    chavesA[0].Check = 1;
                else
                    chavesA[0].Check = 0;
                chavesSelect.Add(chavesA[0]);
            }
            if (checkBox2.Visible)
            {
                if (checkBox2.Checked)
                    chavesA[1].Check = 1;
                else
                    chavesA[1].Check = 0;
                chavesSelect.Add(chavesA[1]);
            }
         
         */


    }
}
