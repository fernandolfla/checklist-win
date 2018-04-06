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
    public partial class CheckList_Chaves : Form
    {
        List<Chave> chaves = new List<Entity.Chave>();
        List<Chave> chavesA = new List<Entity.Chave>();
        List<Chave> chavesSelect = new List<Entity.Chave>();
        List<Chave> chavesB = new List<Entity.Chave>();


        Check check = new Check();
        private Entity.Configuracao conf = new Entity.Configuracao();
        public CheckList_Chaves(Check check)
        {


            InitializeComponent();


            this.check = check;

            int area = 0;  //seta a area do alfa que verá as chaves
            try { area = Convert.ToInt32(check.Area); } catch { area = 1; }

            CheckListBLL BLL = new CheckListBLL();

            chaves = BLL.ListaChaves();

            //int count = 0;

            if (chaves != null)
            {

                //chavesA = chaves;  // depois apagar

                foreach (Chave p in chaves)
                {
                    int a1 = 1;
                    try { a1 = Convert.ToInt32(p.Area); } catch { }
                    if(area == a1)
                        chavesA.Add(p);
                }

                //separação por área apos criar opção no banco


                if (chavesA != null)
                {

                        checkBox1.Visible = true;
                        checkBox1.Text = chavesA[0].Nome;
                    
                    if (chavesA.Count > 1)
                    {
                        checkBox2.Visible = true;
                        checkBox2.Text = chavesA[1].Nome;
                    }
                    if (chavesA.Count > 2)
                    {
                        checkBox3.Visible = true;
                        checkBox3.Text = chavesA[2].Nome;
                    }
                    if (chavesA.Count > 3)
                    {
                        checkBox4.Visible = true;
                        checkBox4.Text = chavesA[3].Nome;
                    }
                    if (chavesA.Count > 4)
                    {
                        checkBox5.Visible = true;
                        checkBox5.Text = chavesA[4].Nome;
                    }
                    if (chavesA.Count > 5)
                    {
                        checkBox6.Visible = true;
                        checkBox6.Text = chavesA[5].Nome;
                    }
                    if (chavesA.Count > 6)
                    {
                        checkBox7.Visible = true;
                        checkBox7.Text = chavesA[6].Nome;
                    }
                    if (chavesA.Count > 7)
                    {
                        checkBox8.Visible = true;
                        checkBox8.Text = chavesA[7].Nome;
                    }
                    if (chavesA.Count > 8)
                    {
                        checkBox9.Visible = true;
                        checkBox9.Text = chavesA[8].Nome;
                    }
                    if (chavesA.Count > 9)
                    {
                        checkBox10.Visible = true;
                        checkBox10.Text = chavesA[9].Nome;
                    }
                    if (chavesA.Count > 10)
                    {
                        checkBox11.Visible = true;
                        checkBox11.Text = chavesA[10].Nome;
                    }

                    if (chavesA.Count > 11)
                    {
                        checkBox12.Visible = true;
                        checkBox12.Text = chavesA[11].Nome;
                    }

                    if (chavesA.Count > 12)
                    {
                        checkBox13.Visible = true;
                        checkBox13.Text = chavesA[12].Nome;
                    }

                    if (chavesA.Count > 13)
                    {
                        checkBox14.Visible = true;
                        checkBox14.Text = chavesA[13].Nome;
                    }

                    if (chavesA.Count > 14)
                    {
                        checkBox15.Visible = true;
                        checkBox15.Text = chavesA[14].Nome;
                    }

                    if (chavesA.Count > 15)
                    {
                        checkBox16.Visible = true;
                        checkBox16.Text = chavesA[15].Nome;
                    }

                    if (chavesA.Count > 16)
                    {
                        checkBox17.Visible = true;
                        checkBox17.Text = chavesA[16].Nome;
                    }

                    if (chavesA.Count > 17)
                    {
                        checkBox18.Visible = true;
                        checkBox18.Text = chavesA[17].Nome;
                    }

                    if (chavesA.Count > 18)
                    {
                        checkBox19.Visible = true;
                        checkBox19.Text = chavesA[18].Nome;
                    }

                    if (chavesA.Count > 19)
                    {
                        checkBox20.Visible = true;
                        checkBox20.Text = chavesA[19].Nome;
                    }

                    if (chavesA.Count > 20)
                    {
                        checkBox21.Visible = true;
                        checkBox21.Text = chavesA[20].Nome;
                    }

                    if (chavesA.Count > 21)
                    {
                        checkBox22.Visible = true;
                        checkBox22.Text = chavesA[21].Nome;
                    }

                    if (chavesA.Count > 22)
                    {
                        checkBox23.Visible = true;
                        checkBox23.Text = chavesA[22].Nome;
                    }

                    if (chavesA.Count > 23)
                    {
                        checkBox24.Visible = true;
                        checkBox24.Text = chavesA[23].Nome;
                    }

                    if (chavesA.Count > 24)
                    {
                        checkBox25.Visible = true;
                        checkBox25.Text = chavesA[24].Nome;
                    }

                    if (chavesA.Count > 25)
                    {
                        checkBox26.Visible = true;
                        checkBox26.Text = chavesA[25].Nome;
                    }

                    if (chavesA.Count > 26)
                    {
                        checkBox27.Visible = true;
                        checkBox27.Text = chavesA[26].Nome;
                    }

                    if (chavesA.Count > 27)
                    {
                        checkBox28.Visible = true;
                        checkBox28.Text = chavesA[27].Nome;
                    }


                }


            }


        }


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
            if (checkBox3.Visible)
            {
                if (checkBox3.Checked)
                    chavesA[2].Check = 1;
                else
                    chavesA[2].Check = 0;
                chavesSelect.Add(chavesA[2]);
            }
            if (checkBox4.Visible)
            {
                if (checkBox4.Checked)
                    chavesA[3].Check = 1;
                else
                    chavesA[3].Check = 0;
                chavesSelect.Add(chavesA[3]);
            }
            if (checkBox5.Visible)
            {
                if (checkBox5.Checked)
                    chavesA[4].Check = 1;
                else
                    chavesA[4].Check = 0;
                chavesSelect.Add(chavesA[4]);
            }
            if (checkBox6.Visible)
            {
                if (checkBox6.Checked)
                    chavesA[5].Check = 1;
                else
                    chavesA[5].Check = 0;
                chavesSelect.Add(chavesA[5]);
            }
            if (checkBox7.Visible)
            {
                if (checkBox7.Checked)
                    chavesA[6].Check = 1;
                else
                    chavesA[6].Check = 0;
                chavesSelect.Add(chavesA[6]);
            }
            if (checkBox8.Visible)
            {
                if (checkBox8.Checked)
                    chavesA[7].Check = 1;
                else
                    chavesA[7].Check = 0;
                chavesSelect.Add(chavesA[7]);
            }
            if (checkBox9.Visible)
            {
                if (checkBox9.Checked)
                    chavesA[8].Check = 1;
                else
                    chavesA[8].Check = 0;
                chavesSelect.Add(chavesA[8]);
            }
            if (checkBox10.Visible)
            {
                if (checkBox10.Checked)
                    chavesA[9].Check = 1;
                else
                    chavesA[9].Check = 0;
                chavesSelect.Add(chavesA[9]);
            }
            if (checkBox11.Visible)
            {
                if (checkBox11.Checked)
                    chavesA[10].Check = 1;
                else
                    chavesA[10].Check = 0;
                chavesSelect.Add(chavesA[10]);
            }
            if (checkBox12.Visible)
            {
                if (checkBox12.Checked)
                    chavesA[11].Check = 1;
                else
                    chavesA[11].Check = 0;
                chavesSelect.Add(chavesA[11]);
            }
            if (checkBox13.Visible)
            {
                if (checkBox13.Checked)
                    chavesA[12].Check = 1;
                else
                    chavesA[12].Check = 0;
                chavesSelect.Add(chavesA[12]);
            }
            if (checkBox14.Visible)
            {
                if (checkBox14.Checked)
                    chavesA[13].Check = 1;
                else
                    chavesA[13].Check = 0;
                chavesSelect.Add(chavesA[13]);
            }
            if (checkBox15.Visible)
            {
                if (checkBox15.Checked)
                    chavesA[14].Check = 1;
                else
                    chavesA[14].Check = 0;
                chavesSelect.Add(chavesA[14]);
            }
            if (checkBox16.Visible)
            {
                if (checkBox16.Checked)
                    chavesA[15].Check = 1;
                else
                    chavesA[15].Check = 0;
                chavesSelect.Add(chavesA[15]);
            }
            if (checkBox17.Visible)
            {
                if (checkBox17.Checked)
                    chavesA[16].Check = 1;
                else
                    chavesA[16].Check = 0;
                chavesSelect.Add(chavesA[16]);
            }
            if (checkBox18.Visible)
            {
                if (checkBox18.Checked)
                    chavesA[17].Check = 1;
                else
                    chavesA[17].Check = 0;
                chavesSelect.Add(chavesA[17]);
            }
            if (checkBox19.Visible)
            {
                if (checkBox19.Checked)
                    chavesA[18].Check = 1;
                else
                    chavesA[18].Check = 0;
                chavesSelect.Add(chavesA[18]);
            }
            if (checkBox20.Visible)
            {
                if (checkBox20.Checked)
                    chavesA[19].Check = 1;
                else
                    chavesA[19].Check = 0;
                chavesSelect.Add(chavesA[19]);
            }
            if (checkBox21.Visible)
            {
                if (checkBox21.Checked)
                    chavesA[20].Check = 1;
                else
                    chavesA[20].Check = 0;
                chavesSelect.Add(chavesA[20]);
            }
            if (checkBox22.Visible)
            {
                if (checkBox22.Checked)
                    chavesA[21].Check = 1;
                else
                    chavesA[21].Check = 0;
                chavesSelect.Add(chavesA[21]);
            }
            if (checkBox23.Visible)
            {
                if (checkBox23.Checked)
                    chavesA[22].Check = 1;
                else
                    chavesA[22].Check = 0;
                chavesSelect.Add(chavesA[22]);
            }
            if (checkBox24.Visible)
            {
                if (checkBox24.Checked)
                    chavesA[23].Check = 1;
                else
                    chavesA[23].Check = 0;
                chavesSelect.Add(chavesA[23]);
            }
            if (checkBox25.Visible)
            {
                if (checkBox25.Checked)
                    chavesA[24].Check = 1;
                else
                    chavesA[24].Check = 0;
                chavesSelect.Add(chavesA[24]);
            }
            if (checkBox26.Visible)
            {
                if (checkBox26.Checked)
                    chavesA[25].Check = 1;
                else
                    chavesA[25].Check = 0;
                chavesSelect.Add(chavesA[25]);
            }
            if (checkBox27.Visible)
            {
                if (checkBox27.Checked)
                    chavesA[26].Check = 1;
                else
                    chavesA[26].Check = 0;
                chavesSelect.Add(chavesA[26]);
            }
            if (checkBox28.Visible)
            {
                if (checkBox28.Checked)
                    chavesA[27].Check = 1;
                else
                    chavesA[27].Check = 0;
                chavesSelect.Add(chavesA[27]);
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


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            VerificaCheck();
            check.Chaves = chavesSelect;

            CheckListBLL BLL = new CheckListBLL();

            if (BLL.Cadastra(check))
            {
                MessageBox.Show("SUCESSO EM GRAVAR CHECKLIST!! BOM PLANTÃO!!");
            }
            else
                MessageBox.Show("HOUVE ERROS DURANTE O PROCESSO, REINICIE A OPERAÇÃO!!");


            MensagemErro();
            Application.Restart();
        }
    }
}
