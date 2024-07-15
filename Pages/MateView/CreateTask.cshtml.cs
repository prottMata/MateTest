using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MateTest2.MateT1;

namespace MateTest2.Pages.MateView
{
    public class CreateTaskModel : PageModel
    {
        private readonly MateTest2.MateT1.matedbContext _context;

        public CreateTaskModel(MateTest2.MateT1.matedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IdLists"] = new SelectList(_context.Lists, "Id", "Listname");
           
            return Page();
        }

        [BindProperty]
        public MateT1.TableTask TableTask { get; set; }
        public ListsTask ListsTask { get; set; }
        public TableList TableList { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Tasks.Add(TableTask);
            await _context.SaveChangesAsync();
            //_context.Attach(TableTask).State = EntityState.Modified;
            //TableTask.IdStatus = 1;
            //await _context.SaveChangesAsync();
            ListsTask listsTask = new ListsTask { IdLists = id, IdTasks = TableTask.Id };
            _context.ListsTasks.Add(listsTask);
            await _context.SaveChangesAsync();
            /*_context.Attach(ListsTask).State = EntityState.Modified;
            ListsTask.IdTasks = TableTask.Id;
            ListsTask.IdLists = id;
            //ListsTask.IdLists = select
            await _context.SaveChangesAsync();*/
            //ListsTask listsTask = new ListsTask { IdTasks = TableTask.Id };
            //_context.Lists
            //TableTask tableTask = new TableTask { IdStatus = 1 };

            return RedirectToPage("./ListsOut", new {id = id});
        }
    }
}
