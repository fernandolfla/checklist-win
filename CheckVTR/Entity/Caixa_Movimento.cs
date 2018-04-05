using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVTR.Entity
{
    public class Caixa_Movimento
    {
        public long Id { get; set; }
        public int Caixa_Situacao_Id { get; set; }
        public string TipoMovimento { get; set; }
        public int SaidaEntrada { get; set; }
        public double Valor { get; set; }
        public string Numcupom { get; set; }
        public DateTime DataHora { get; set; }
        public string Placa { get; set; }
        public string KM { get; set; }
        public string Autorizado { get; set; }
        public string Tatico { get; set; }
        public string Descricao { get; set; }
        public int Abastecimento { get; set; }
        public byte[] Imagem { get; set; }
        public int SangriaNF { get; set; }
    }
}
