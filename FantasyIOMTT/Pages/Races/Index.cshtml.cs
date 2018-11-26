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
    public class IndexModel : PageModel
    {
        private readonly FantasyIOMTT.Models.FantasyIOMTTContext _context;

        public IndexModel(FantasyIOMTT.Models.FantasyIOMTTContext context)
        {
            _context = context;
        }

        public IList<Races> Races { get;set; }

        public async Task OnGetAsync()
        {
            Races = await _context.Races.ToListAsync();
        }
    }
}
