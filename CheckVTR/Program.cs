using CheckVTR.Component;
using CheckVTR.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckVTR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LerArquivo.Ler();

            Login logar = new Login();
            if (logar.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Principal());
            }
        }
    }
}
