using CheckVTR.Relatorios;
using CheckVTR.Relatorios_Model;
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
    public partial class Rel : Form
    {
        public Rel()
        {
            InitializeComponent();
        }

        private void btnReportCheck_Click(object sender, EventArgs e)
        {

            RelatorioCheck tela = new RelatorioCheck();
            tela.ShowDialog();



        }

        private void btnTrocaOleo_Click(object sender, EventArgs e)
        {
            RelatorioOleo tela = new RelatorioOleo();
            tela.ShowDialog();
        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {

            RelatorioManutencao tela = new RelatorioManutencao();
            tela.ShowDialog();


        }

        private void btnCheckCompleto_Click(object sender, EventArgs e)
        {

            RelatorioCheckCompleto tela = new RelatorioCheckCompleto();
            tela.ShowDialog();



        }
    }
}
