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
    public partial class Manutencao : Form
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        public Manutencao()
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

            MensagemErro();

        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private ManutencaoBD TelaToEntity()
        {
            ManutencaoBD c = new ManutencaoBD();
            c.Placa = comboPlaca.Text;
            c.KM = txtKm.Text;
            c.Local = txtLocal.Text;
            c.Descricao = txtDescricao.Text;
            c.Valor = txtValor.Text.Replace("R$","").Trim().Replace(",",".");

            return c;
        }
        private void LimpaTela()
        {
            comboPlaca.Text = "";
            txtKm.Text = "";
            txtLocal.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            comboPlaca.SelectedIndex = 0;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ManutencaoBD c = new ManutencaoBD();
            ManutencaoBLL BLL = new ManutencaoBLL();

            c = TelaToEntity();

            if (BLL.Cadastra(c))
            {
                MessageBox.Show("MANUTENÇÃO  CADASTRADA COM SUCESSO");
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
    }
}
