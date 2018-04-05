using CheckVTR.BLL;
using CheckVTR.Component;
using CheckVTR.Entity;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckVTR.Relatorios_Model
{
    public partial class RelatorioOleo : Form
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        public RelatorioOleo()
        {
            InitializeComponent();

            OleoBLL BLL = new OleoBLL();

            veiculos = BLL.ListaVeiculos();

            if (veiculos != null)
            {
                comboPlaca.Items.Add("TODAS");
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

        private void RelatorioOleo_Load(object sender, EventArgs e)
        {

            this.reportManutencao.RefreshReport();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            DataTable data = new DataTable();
            RelatoriosBLL BLL = new RelatoriosBLL();
            string oleo = "TODAS";
            if(comboPlaca.SelectedIndex != -1)
                oleo = comboPlaca.Text;

            data = BLL.RelatorioOleo(oleo);
            if (data != null)
            {
                if (data != null)
                {
                    ReportDataSource dsReport = new ReportDataSource("DataSet1", data);  // Dataset1 refere ao dataset dentro do report
                    this.reportManutencao.LocalReport.DataSources.Clear();
                    this.reportManutencao.LocalReport.DataSources.Add(dsReport);
                    this.reportManutencao.LocalReport.Refresh();

                    this.reportManutencao.RefreshReport();
                }
                else
                    MessageBox.Show("Não há nada para exibir");



            }
        }
    }

}
