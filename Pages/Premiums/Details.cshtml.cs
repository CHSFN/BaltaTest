using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BaltaTest.Data;

namespace BaltaTest.Pages_Premiums
{
    public class DetailsModel : PageModel
    {
        private readonly BaltaTest.Data.ApplicationDbContext _context;

        public DetailsModel(BaltaTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Premium Premium { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Premiums == null)
            {
                return NotFound();
            }

            var premium = await _context.Premiums.FirstOrDefaultAsync(m => m.Id == id);
            if (premium == null)
            {
                return NotFound();
            }
            else 
            {
                Premium = premium;
            }
            return Page();
        }
    }
}
