using CheckVTR.BLL;
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

namespace CheckVTR.Relatorios
{
    public partial class RelatorioCheck : Form
    {
        public RelatorioCheck()
        {
            InitializeComponent();
        }

        private void RelatorioCheck_Load(object sender, EventArgs e)
        {

            this.reportCheck.RefreshReport();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            DateTime inicio = dateInicio.Value.Date;
            DataTable data = new DataTable();

            RelatoriosBLL BLL = new RelatoriosBLL();

            data = BLL.RelatorioChecklist(inicio);

            if(data != null)
            {
                if (data != null)
                {
                    ReportDataSource dsReport = new ReportDataSource("DataSet2", data);  // Dataset1 refere ao dataset dentro do report
                    this.reportCheck.LocalReport.DataSources.Clear();
                    this.reportCheck.LocalReport.DataSources.Add(dsReport);
                    this.reportCheck.LocalReport.Refresh();

                    this.reportCheck.RefreshReport();
                }
                else
                    MessageBox.Show("Não há Vendas no Intervalo Pesquisado");


            }


        }
    }
}
