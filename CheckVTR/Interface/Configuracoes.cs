using CheckVTR.BLL;
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
    public partial class Configuracoes : Form
    {
        DataTable Ativos = new DataTable();
        public Configuracoes()
        {
            InitializeComponent();

            dataGridPlantao.Rows.Clear();
            dataGridPlantao.Refresh();

            ConfiguracoesBLL BLL = new ConfiguracoesBLL();


          

            Ativos = BLL.ListaAtivos();

            if(Ativos != null)
            {
                foreach(DataRow linha in Ativos.Rows)
                {
                    string[] row = new string[] { linha.ItemArray[1].ToString(), linha.ItemArray[21].ToString(), linha.ItemArray[2].ToString(), linha.ItemArray[3].ToString(), linha.ItemArray[5].ToString(), };

                    dataGridPlantao.Rows.Add(row);
                }
            }



        }








        private void dataGridPlantao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridPlantao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(Ativos != null)
                if(Ativos.Rows.Count > 0)
                    if (e.RowIndex >= 0)
                    {
                        int user = -1;
                        try { user = (int)Ativos.Rows[e.RowIndex].ItemArray[1]; } catch { user = -1; }
                        Autenticacao.SetUsuario(user);

                        CheckListFinalizar tela = new CheckListFinalizar();
                        tela.ShowDialog();

                    }


        }
    }
}
