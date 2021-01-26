using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBioFinal.Models
{
    public class Cabaz
    {
        [Key]
        public int id { get; set; }

        public List<Produto> cabaz { get; set; }


        public float preco_cabaz { get; set; }

        public int idCliente { get; set; }

        public DateTime dataEntrega { get; set; }

        public string epoca_atual { get; set; }

        public Cabaz()
        {
            int Month = DateTime.Now.Month;
            if (Month <= 2 || Month > 11) epoca_atual = "Inverno";
            else if (Month <= 5 || Month > 2) epoca_atual = "Primavera";
            else if (Month <= 8 || Month > 5) epoca_atual = "Verão";
            else if (Month <= 11 || Month > 8) epoca_atual = "Outono";
        }

        public string adicionarProduto(Produto produto, int quantidade)
        {

            if (produto.epoca == this.epoca_atual)
            {

                for (int i = 0; i <= quantidade; i++)
                {
                    cabaz.Add(produto);
                }

                return "Cabaz atualizado com sucesso!";

            }

            else return "O produto encontra-se fora de época";

        }

        public void removerProduto(Produto produto)
        {
            foreach (Produto p in cabaz)
            {
                if (p.id == produto.id)
                {
                    cabaz.Remove(p);
                }
            }
        }

        public float calcularPrecoCabaz()
        {
            float total = 0;
            foreach (Produto p in cabaz)
            {
                total = total + p.preco;
            }
            return total;
        }


    }
}
