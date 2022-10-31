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
    public class DetailsModel : PageModel
    {
        private readonly DeseretMegaDesk.Data.DeseretMegaDeskContext _context;

        public DetailsModel(DeseretMegaDesk.Data.DeseretMegaDeskContext context)
        {
            _context = context;
        }

      public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.DeskQuote == null)
            {
                return NotFound();
            }

            var deskquote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);
            if (deskquote == null)
            {
                return NotFound();
            }
            else 
            {
                DeskQuote = deskquote;
            }
            return Page();
        }
    }
}
