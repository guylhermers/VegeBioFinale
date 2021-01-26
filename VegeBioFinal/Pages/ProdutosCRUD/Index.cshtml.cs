using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VegeBioFinal.Data;
using VegeBioFinal.Models;

namespace VegeBioFinal.Pages.ProdutosCRUD
{
    public class IndexModel : PageModel
    {
        private readonly VegeBioFinal.Data.VegeBioFinalContext _context;

        [BindProperty]
        public Produto produto { get; set; }
        public Cabaz cabazprodutos { get; set; }
        public int Quantidade { get; set; }

        public IndexModel(VegeBioFinal.Data.VegeBioFinalContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public ListaProdutos Lista { get; set; }

        public async Task OnGetAsync()
        {

            Produto = await _context.Produto.ToListAsync();

            foreach (var p in Produto)
            {
                Lista.adicionarProduto(p);
            }
        }

        public IActionResult OnPost()
        {
            foreach (Produto p in Lista.ListaProduto)
            {
                if(p.id == produto.id)
                {
                    cabazprodutos.adicionarProduto(produto, Quantidade);
                }
            }
            return Page();
        }
    }
}
