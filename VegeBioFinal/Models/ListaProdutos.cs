using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBioFinal.Models
{
    public class ListaProdutos
    {
        private List<Produto> listaProduto;
        private string epocaatual;

        public ListaProdutos()
        {
            int Month = DateTime.Now.Month;
            if (Month <= 2 || Month > 11) epocaatual = "Inverno";
            else if (Month <= 5 || Month > 2) epocaatual = "Primavera";
            else if (Month <= 8 || Month > 5) epocaatual = "Verão";
            else if (Month <= 11 || Month > 8) epocaatual = "Outono";
        }

        public bool adicionarProduto(Produto produto)
        {
            if (produto.epoca == EpocaAtual)
            {
                ListaProduto.Add(produto);
                return true;
            }

            else return false;

        }

        public void removerProduto(Produto produto)
        {
            foreach (Produto p in ListaProduto)
            {
                if (p.id == produto.id)
                {
                    ListaProduto.Remove(p);
                }
            }
        }

        public string verificarEpoca(Produto p)
        {
            if (p.epoca == this.EpocaAtual)
            {
                return ($"O produto encontra-se na época atual {p.epoca}");
            }
            else return ($"O produto encontra-se na época {p.epoca}");
        }

        public float verificarPreco(Produto p)
        {
            return p.preco;
        }

        public List<Produto> ListaProduto { get => listaProduto; set => listaProduto = value; }
        public string EpocaAtual { get => epocaatual; set => epocaatual = value; }
    }
}

    