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
                new Produto{nome = "alface",descricao ="Alface" , preco = 3, imageurl ="alface.jpg"},
                new Produto{nome = "alho_frances",descricao ="Alho Francês" , preco = 4, imageurl ="alhofrances.jpg"},
                new Produto{nome = "Batata",descricao ="Batata" , preco = 1, imageurl ="batata.jpg"},
                new Produto{nome = "Cenoura",descricao ="Cenoura" , preco = 1, imageurl ="cenoura.jpg"},
                new Produto{nome = "Pepino",descricao ="Pepino" , preco = 2, imageurl ="pepino.jpg"},
                new Produto{nome = "Tomate",descricao ="Tomate" , preco = 3, imageurl ="tomates.jpg"},
                new Produto{nome = "Curgete",descricao ="Curgete" , preco = 4, imageurl ="corgete.jpg"},
                new Produto{nome = "Laranja",descricao ="Laranja" , preco = 2, imageurl ="laranja.jpg"},
                new Produto{nome = "Maçã",descricao ="Maçã" , preco = 3, imageurl ="maça.jpg"},
                new Produto{nome = "Mirtilo",descricao ="Mirtilo" , preco = 7, imageurl ="mirtilo.jpg"},
                new Produto{nome = "Morango",descricao="Morango" , preco = 5, imageurl ="morangos.jpg"},
                new Produto{nome = "Limão",descricao ="Limão" , preco = 2, imageurl ="lemon.jpg"},
                new Produto{nome = "Ameixa",descricao ="Ameixa" , preco = 6, imageurl ="ameixa.jpg"},
                new Produto{nome = "Manga",descricao ="Manga" , preco = 12, imageurl ="manga.jpg"}
            };

            foreach (Produto produto in produtos)
            {
                context.Produto.Add(produto);
            }
            context.SaveChanges();
        }
    }
}