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
    public class DetailsModel : PageModel
    {
        private readonly VegeBioFinal.Data.VegeBioFinalContext _context;

        public DetailsModel(VegeBioFinal.Data.VegeBioFinalContext context)
        {
            _context = context;
        }

        public Cabaz Cabaz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cabaz = await _context.Cabaz.FirstOrDefaultAsync(m => m.id == id);

            if (Cabaz == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
