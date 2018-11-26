using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FantasyIOMTT.Models;

namespace FantasyIOMTT.Pages.Races
{
    public class DeleteModel : PageModel
    {
        private readonly FantasyIOMTT.Models.FantasyIOMTTContext _context;

        public DeleteModel(FantasyIOMTT.Models.FantasyIOMTTContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Races Races { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Races = await _context.Races.FirstOrDefaultAsync(m => m.ID == id);

            if (Races == null)
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

            Races = await _context.Races.FindAsync(id);

            if (Races != null)
            {
                _context.Races.Remove(Races);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
