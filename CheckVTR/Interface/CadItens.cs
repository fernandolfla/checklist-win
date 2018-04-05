using CheckVTR.Component;
using System;
using CheckVTR.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckVTR.BLL;

namespace CheckVTR.Interface
{
    public partial class CadItens : Form
    {
        public CadItens()
        {
            InitializeComponent();


            txtNome.Text = "";
            txtCodigo.Text = "";
        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private void LimpaTela()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            checkNormal.Checked = true;
            checkPorcentagem.Checked = false;
        }

        private Item TelaToEntity()
        {
            Item item = new Item();

            item.Id = txtCodigo.Text;
            item.Nome = txtNome.Text;
            if (checkNormal.Checked)
                item.Tipo = 0;
            else
                item.Tipo = 1;

            return item;

        }

        private void EntityToTela(Item item)
        {
            txtCodigo.Text = item.Id;
            txtNome.Text = item.Nome;
            if (item.Tipo == 0)
            {
                checkNormal.Checked = true;
                checkPorcentagem.Checked = false;
            }
            else
            {
                checkNormal.Checked = false;
                checkPorcentagem.Checked = true;
            }

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            CadItemBLL BLL = new CadItemBLL();

            item = TelaToEntity();
            if (item.Id.Length == 0)
            {
                if (BLL.Cadastra(item))
                {
                    MessageBox.Show("Cadastro Realizado com Sucesso");
                    LimpaTela();
                }
                else
                {
                    MessageBox.Show("Verifique os campos Obrigatórios, O nome deve conter ao menos 3 letras");
                    MensagemErro();
                }
            }
            else
                MessageBox.Show("Não é possível editar");

            MensagemErro();

        }

        private void Normal_changed(object sender, EventArgs e)
        {
            if (checkNormal.Checked)
                checkPorcentagem.Checked = false;
            else
                checkPorcentagem.Checked = true;
        }

        private void Porcentagem_Changed(object sender, EventArgs e)
        {
            if (checkPorcentagem.Checked)
                checkNormal.Checked = false;
            else
                checkNormal.Checked = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            CadItemBLL BLL = new CadItemBLL();
            Item item = new Item();

            item = TelaToEntity();

            item = BLL.BuscaAnt(item);

            if (item != null)
            {
                LimpaTela();
                EntityToTela(item);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            CadItemBLL BLL = new CadItemBLL();
            Item item = new Item();

            item = TelaToEntity();

            item = BLL.BuscaProx(item);

            if (item != null)
            {
                LimpaTela();
                EntityToTela(item);
            }
            else MessageBox.Show("Erro ao Buscar, Reinicie o Programa, se Persistir entre em contato com o Suporte");
            MensagemErro();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Realmente deseja Excluir? A Exclusão pode ocasionar inconsistencia no Banco de Dados! ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                CadItemBLL BLL = new CadItemBLL();
                Item c = new Item();
                c = TelaToEntity();
                if (BLL.Apaga(c.Id))
                {
                    MessageBox.Show("Deletado com Sucesso");
                }
                else MessageBox.Show("O Item já foi utilizado e não poderá ser excluido, ou Selecione um Item Válido!");

                LimpaTela();
                MensagemErro();




            }
        }
    }
}
