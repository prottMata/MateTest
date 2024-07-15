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
    public class ListsOutModel : PageModel
    {
        private readonly matedbContext _context;

        public ListsOutModel(matedbContext context)
        {
            _context = context;
        }
        public IList<ListsTask> ListsTasks { get; set; }
        public int CurrentListId;
        //public List<string> TaskNames { get; set; } //= new List<string>();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            CurrentListId = (int)id;
            if (id == null)
            {
                return NotFound();
            }
            ListsTasks = await _context.ListsTasks
                .Where(lt => lt.IdLists == id)
                .Include(t => t.IdTasksNavigation)
                .Include(s => s.IdTasksNavigation.IdStatusNavigation)
                .ToListAsync();
            if (ListsTasks == null)
            {
                return NotFound();
            }
            return Page();
            /*TaskNames = await (from t in _context.Set<mate.TableTask>()
                               from lt in _context.Set<ListsTask>()
                               where
                               (lt.IdLists == id) &&
                               (lt.IdTasks == t.Id)
                               select new { t.Taskname }).ToListAsync();*/

            //return query;
        }
    }
}
