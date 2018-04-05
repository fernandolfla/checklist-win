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
    public partial class Oleo : Form
    {

        private List<Veiculo> veiculos = new List<Veiculo>();
        public Oleo()
        {
            InitializeComponent();

            OleoBLL BLL = new OleoBLL();

            veiculos = BLL.ListaVeiculos();

            if (veiculos != null)
            {
                foreach (Veiculo p in veiculos)
                {
                    comboPlaca.Items.Add(p.Placa);
                }
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

        private OleoBD TelaToEntity()
        {
            OleoBD c = new OleoBD();
            c.Placa = comboPlaca.Text;
            c.Km = txtKmTroca.Text;
            c.Local = txtLocal.Text;
            c.Data = DateTime.Now;
            c.Valor = txtValor.Text.Replace("R$", "").Trim().Replace(",", ".");

            return c;
        }
        private void LimpaTela()
        {
            comboPlaca.Text = "";
            txtKmTroca.Text = "";
            txtLocal.Text = "";
            txtModelo.Text = "";
            txtValor.Text = "";
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            OleoBD c = new OleoBD();
           OleoBLL BLL = new OleoBLL();

            c = TelaToEntity();
            ManutencaoBD m = OleoToManutencao(c);
           

            if (BLL.Cadastra(c,m))
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

        private void AtualizaTextModelo()
        {
            try
            {
                if (veiculos != null)
                {
                    foreach (Veiculo p in veiculos)
                    {
                        if (p.Placa.Equals(comboPlaca.SelectedItem.ToString()))
                            txtModelo.Text = p.Modelo;
                    }
                }
            }
            catch (Exception) { }
        }

        private ManutencaoBD OleoToManutencao(OleoBD o)
        {
            ManutencaoBD m = new ManutencaoBD();
            m.Descricao = "TROCA DE ÓLEO";
            m.KM = o.Km;
            m.Local = o.Local;
            m.Placa = o.Placa;
            m.Valor = o.Valor;

            return m;
        }

        private void comboPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTextModelo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
    }
}
