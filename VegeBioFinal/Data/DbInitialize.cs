using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegeBioFinal.Models;
using VegeBioFinal.Data;

namespace VegeBioFinal.Data
{
    public static class DbInitializer
    {
        public static void Initialize(VegeBioFinalContext context)
        {
            context.Database.EnsureCreated();
            if (context.Produto.Any())
            {
                return;
            }

            var produtos = new Produto[]
            {
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"},
                new Produto{nome = "produto 1",descricao ="primeiro produto" , preco = 69, imageurl ="Skate.png"}
            };

            foreach (Produto produto in produtos)
            {
                context.Produto.Add(produto);
            }
            context.SaveChanges();
        }
    }
}