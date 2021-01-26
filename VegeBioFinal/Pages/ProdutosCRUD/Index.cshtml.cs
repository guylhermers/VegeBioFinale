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

        public Produto produto { get; set; }
        public IndexModel(VegeBioFinal.Data.VegeBioFinalContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
