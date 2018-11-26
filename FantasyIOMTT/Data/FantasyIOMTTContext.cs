using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FantasyIOMTT.Models
{
    public class FantasyIOMTTContext : DbContext
    {
        public FantasyIOMTTContext (DbContextOptions<FantasyIOMTTContext> options)
            : base(options)
        {
        }

        public DbSet<FantasyIOMTT.Models.Races> Races { get; set; }
    }
}
