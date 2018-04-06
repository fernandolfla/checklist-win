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
        }

        private Item TelaToEntity()
        {
            Item item = new Item();

            item.Id = txtCodigo.Text;
            item.Nome = txtNome.Text;
          

            return item;

        }

        private void EntityToTela(Item item)
        {
            txtCodigo.Text = item.Id;
            txtNome.Text = item.Nome;
            

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

            int cod = 2;
            try { cod = Convert.ToInt32(txtCodigo.Text); } catch { cod = 2; }

            if (cod != 1)
            {
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
            else
                MessageBox.Show("O item Óleo é o único que não pode ser deletado");
        }





    }
}
