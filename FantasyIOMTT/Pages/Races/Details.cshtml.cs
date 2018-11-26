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
    public class DetailsModel : PageModel
    {
        private readonly FantasyIOMTT.Models.FantasyIOMTTContext _context;

        public DetailsModel(FantasyIOMTT.Models.FantasyIOMTTContext context)
        {
            _context = context;
        }

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
    }
}
