using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MateTest2.MateT1;

namespace MateTest2
{
    public class TableTasksController : Controller
    {
        private readonly matedbContext _context;

        public TableTasksController(matedbContext context)
        {
            _context = context;
        }

        // GET: TableTasks
        public async Task<IActionResult> Index()
        {
            var matedbContext = _context.Tasks.Include(t => t.IdStatusNavigation);
            return View(await matedbContext.ToListAsync());
        }

        // GET: TableTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableTask = await _context.Tasks
                .Include(t => t.IdStatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableTask == null)
            {
                return NotFound();
            }

            return View(tableTask);
        }

        // GET: TableTasks/Create
        public IActionResult Create()
        {
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id");
            return View();
        }

        // POST: TableTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Taskname,IdStatus")] MateT1.TableTask tableTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id", tableTask.IdStatus);
            return View(tableTask);
        }

        // GET: TableTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableTask = await _context.Tasks.FindAsync(id);
            if (tableTask == null)
            {
                return NotFound();
            }
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id", tableTask.IdStatus);
            return View(tableTask);
        }

        // POST: TableTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Taskname,IdStatus")] MateT1.TableTask tableTask)
        {
            if (id != tableTask.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableTaskExists(tableTask.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id", tableTask.IdStatus);
            return View(tableTask);
        }

        // GET: TableTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableTask = await _context.Tasks
                .Include(t => t.IdStatusNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableTask == null)
            {
                return NotFound();
            }

            return View(tableTask);
        }

        // POST: TableTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableTask = await _context.Tasks.FindAsync(id);
            _context.Tasks.Remove(tableTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableTaskExists(int id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }
    }
}
