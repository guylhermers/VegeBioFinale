using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBioFinal.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string morada { get; set; }
        public int nif { get; set; }
        public string codigo_postal { get; set; }
    }
}
