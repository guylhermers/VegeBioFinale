using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VegeBioFinal.Data;
using VegeBioFinal.Models;

namespace VegeBioFinal.Pages.CabazCRUD
{
    public class IndexModel : PageModel
    {
        private readonly VegeBioFinal.Data.VegeBioFinalContext _context;

        public IndexModel(VegeBioFinal.Data.VegeBioFinalContext context)
        {
            _context = context;
        }

        public IList<Cabaz> Cabaz { get;set; }

        public async Task OnGetAsync()
        {
            Cabaz = await _context.Cabaz.ToListAsync();
        }
    }
}
