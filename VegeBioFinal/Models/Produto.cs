using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBioFinal.Models
{
    public class Produto
    {

        [Key]
        public int id { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Display(Name = "Estação")]
        public string epoca { get; set; }

        [Display(Name = "Preço")]
        public float preco { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        public int quantidade { get; set; }

        public string tipo { get; set; }

        public string imageurl { get; set; }

    }
}
