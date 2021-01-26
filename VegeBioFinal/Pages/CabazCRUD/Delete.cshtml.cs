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
    public class DeleteModel : PageModel
    {
        private readonly VegeBioFinal.Data.VegeBioFinalContext _context;

        public DeleteModel(VegeBioFinal.Data.VegeBioFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cabaz = await _context.Cabaz.FindAsync(id);

            if (Cabaz != null)
            {
                _context.Cabaz.Remove(Cabaz);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
