using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FantasyIOMTT.Models;

namespace FantasyIOMTT.Pages.Races
{
    public class EditModel : PageModel
    {
        private readonly FantasyIOMTT.Models.FantasyIOMTTContext _context;

        public EditModel(FantasyIOMTT.Models.FantasyIOMTTContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Races).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RacesExists(Races.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RacesExists(int id)
        {
            return _context.Races.Any(e => e.ID == id);
        }
    }
}
