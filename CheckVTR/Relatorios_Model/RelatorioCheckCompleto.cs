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

namespace CheckVTR.Relatorios_Model
{
    public partial class RelatorioCheckCompleto : Form
    {
        public RelatorioCheckCompleto()
        {
            InitializeComponent();






        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DateTime inicio = dateInicio.Value.Date;
            DataTable data = new DataTable();
            DataTable data2 = new DataTable();

            RelatoriosBLL BLL = new RelatoriosBLL();


            data = BLL.RelatorioChecklist(inicio);

            data2 = BLL.RelatorioChecklist_Chaves(2);

            if (data != null)
            {
                if (data != null)
                {
                    ReportDataSource dsReport = new ReportDataSource("DataSet1", data);
                    //ReportDataSource dsReport2 = new ReportDataSource("DataSet2", data2); // Dataset1 refere ao dataset dentro do report
                    this.reportCheckCompleto.LocalReport.DataSources.Clear();
                    this.reportCheckCompleto.LocalReport.DataSources.Add(dsReport);
                    this.reportCheckCompleto.LocalReport.Refresh();

                    this.reportCheckCompleto.RefreshReport();
                }
                else
                    MessageBox.Show("Não há Vendas no Intervalo Pesquisado");


            }





        }
    }
}
