using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MateTest2.MateT1;

namespace MateTest2.Pages.MateView
{
    public class DetailsModel : PageModel
    {
        private readonly MateTest2.MateT1.matedbContext _context;

        public DetailsModel(MateTest2.MateT1.matedbContext context)
        {
            _context = context;
        }

        public TableList List { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List = await _context.Lists
                .Include(l => l.Users).FirstOrDefaultAsync(m => m.Id == id);

            if (List == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
