using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVTR.Entity
{
    public class Caixa_Situacao
    {
        public int Id { get; set; }
        public int Caixa_Id { get; set; }
        public int Situacao_Id { get; set; }
        public string Situacao_Nome { get; set; }
        public double ValorInicial { get; set; }
        public double TotalEntradas { get; set; }
        public double TotalSaidas { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public double TotalDinheiro { get; set; }




    }
}
