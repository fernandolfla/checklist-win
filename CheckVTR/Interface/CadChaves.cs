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
    public partial class CadChaves : Form
    {
        private Entity.Configuracao conf = new Entity.Configuracao();
        public CadChaves()
        {
            InitializeComponent();

            ConfiguracoesBLL BLL3 = new ConfiguracoesBLL();
            conf = BLL3.Busca();

            if (conf != null)
            {
                int qtd;
                try { qtd = Convert.ToInt32(conf.QtdAreas); } catch { qtd = 1; }
                for (int i = 1; i <= qtd; i++)
                {
                    comboArea.Items.Add(i);
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

        private Chave TelaToEntity()
        {
            Chave c = new Chave();
            c.Nome = txtCliente.Text;
            c.Area = comboArea.Text;
            c.Id = txtCodCli.Text;
            return c;
        }
        private void LimpaTela()
        {
            txtCodCli.Text = "";
            txtCliente.Text = "";
            comboArea.SelectedIndex = 0;
        }
        private void EntityToTela(Chave c)
        {
            txtCodCli.Text = c.Id;
            txtCliente.Text = c.Nome;
            comboArea.Text = c.Area;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Chave c = new Chave();
            CadChavesBLL BLL = new CadChavesBLL();

            c = TelaToEntity();

            if (BLL.Cadastra(c))
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CadChavesBLL BLL = new CadChavesBLL();
            Chave c = new Chave();

            c = TelaToEntity();

            c = BLL.BuscaAnt(c);

            if (c != null)
            {
                LimpaTela();
                EntityToTela(c);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadChavesBLL BLL = new CadChavesBLL();
            Chave c = new Chave();

            c = TelaToEntity();

            c= BLL.BuscaProx(c);

            if (c!= null)
            {
                LimpaTela();
                EntityToTela(c);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            
            DialogResult Result = MessageBox.Show("Realmente deseja Excluir? A Exclusão pode ocasionar inconsistencia no Banco de Dados! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                CadChavesBLL BLL = new CadChavesBLL();
                Chave c = new Chave();
                c = TelaToEntity();
                if (BLL.Apaga(c.Id))
                {
                    MessageBox.Show("Deletado com Sucesso");
                }
                else MessageBox.Show("O Cliente já foi utilizado e não poderá ser excluido, ou Selecione um cliente Válido!");

                LimpaTela();
                MensagemErro();

            }


        }
    }
}
