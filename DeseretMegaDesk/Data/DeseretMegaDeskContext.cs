using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeseretMegaDesk.Models;

namespace DeseretMegaDesk.Data
{
    public class DeseretMegaDeskContext : DbContext
    {
        public DeseretMegaDeskContext (DbContextOptions<DeseretMegaDeskContext> options)
            : base(options)
        {
        }

        public DbSet<DeseretMegaDesk.Models.DeskQuote> DeskQuote { get; set; } = default!;
    }
}
