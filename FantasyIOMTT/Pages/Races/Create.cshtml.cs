using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FantasyIOMTT.Models;

namespace FantasyIOMTT.Pages.Races
{
    public class CreateModel : PageModel
    {
        private readonly FantasyIOMTT.Models.FantasyIOMTTContext _context;

        public CreateModel(FantasyIOMTT.Models.FantasyIOMTTContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Races Races { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Races.Add(Races);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}