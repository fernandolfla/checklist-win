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
    public partial class RelatorioManutencao : Form
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        public RelatorioManutencao()
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

            //SETA O FINAL DO DATEPIKER PARA HOJE
            dateFim.Value = DateTime.Now;

            //SETA O INICIO DO DATEPIKER PARA INICIO DO MES

            DateTime dia = new DateTime();
            dia = DateTime.Now;
            dia = new DateTime(dia.Year,dia.Month,1);

            dateInicio.Value = dia.Date;

        }

        private void MensagemErro()
        {
            if (Erros.GetHaErro())
            {
                MessageBox.Show(Erros.GetMensagemErro() + " " + Erros.GetErroBanco());
                Erros.SetHaErro(false);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            DataTable data = new DataTable();
            RelatoriosBLL BLL = new RelatoriosBLL();
            string oleo = "TODAS";
            if (comboPlaca.SelectedIndex != -1)
                oleo = comboPlaca.Text;

            data = BLL.RelatorioManutencao(oleo,dateInicio.Value,dateFim.Value);
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
