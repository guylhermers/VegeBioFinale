using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VegeBioFinal.Data;
using VegeBioFinal.Models;

namespace VegeBioFinal.Pages.CabazCRUD
{
    public class CreateModel : PageModel
    {
        private readonly VegeBioFinal.Data.VegeBioFinalContext _context;

        public CreateModel(VegeBioFinal.Data.VegeBioFinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cabaz Cabaz { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cabaz.Add(Cabaz);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
