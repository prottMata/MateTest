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
    public class Index1Model : PageModel
    {
        private readonly MateTest2.MateT1.matedbContext _context;

        public Index1Model(MateTest2.MateT1.matedbContext context)
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
            string query = "INSERT INTO lists_tasks (id_lists, id_tasks) VALUES (list_importance, current_task_id)";
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
