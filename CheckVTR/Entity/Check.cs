using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVTR.Entity
{
    public class Check
    {

        public string Tatico { get; set; }
        public string CodTatico { get; set; }
        public string Area { get; set; }
        public string Placa { get; set; }
        public string KmInicial { get; set; }
        public string Obs { get; set; }
        public string Combustivel { get; set; }


        public List<Chave> Chaves = new List<Entity.Chave>();





    }
}
