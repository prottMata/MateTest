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
    public class IndexModel : PageModel
    {
        private readonly MateTest2.MateT1.matedbContext _context;

        public IndexModel(MateTest2.MateT1.matedbContext context)
        {
            _context = context;
        }

        public IList<TableList> List { get;set; }

        public async Task OnGetAsync()
        {
            List = await _context.Lists
                .Include(l => l.Users).ToListAsync();
        }
    }
}
