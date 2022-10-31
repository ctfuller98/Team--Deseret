using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeseretMegaDesk.Data;
using DeseretMegaDesk.Models;

namespace DeseretMegaDesk.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly DeseretMegaDesk.Data.DeseretMegaDeskContext _context;

        public IndexModel(DeseretMegaDesk.Data.DeseretMegaDeskContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.DeskQuote != null)
            {
                DeskQuote = await _context.DeskQuote.ToListAsync();
            }
        }
    }
}
