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
    public class SubtasksController : Controller
    {
        private readonly matedbContext _context;

        public SubtasksController(matedbContext context)
        {
            _context = context;
        }

        // GET: Subtasks
        public async Task<IActionResult> Index()
        {
            var matedbContext = _context.Subtasks.Include(s => s.IdStatusNavigation).Include(s => s.IdTaskNavigation);
            return View(await matedbContext.ToListAsync());
        }

        // GET: Subtasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subtask = await _context.Subtasks
                .Include(s => s.IdStatusNavigation)
                .Include(s => s.IdTaskNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subtask == null)
            {
                return NotFound();
            }

            return View(subtask);
        }

        // GET: Subtasks/Create
        public IActionResult Create()
        {
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id");
            ViewData["IdTask"] = new SelectList(_context.Tasks, "Id", "Id");
            return View();
        }

        // POST: Subtasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdTask,SubtaskName,IdStatus")] Subtask subtask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subtask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id", subtask.IdStatus);
            ViewData["IdTask"] = new SelectList(_context.Tasks, "Id", "Id", subtask.IdTask);
            return View(subtask);
        }

        // GET: Subtasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subtask = await _context.Subtasks.FindAsync(id);
            if (subtask == null)
            {
                return NotFound();
            }
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id", subtask.IdStatus);
            ViewData["IdTask"] = new SelectList(_context.Tasks, "Id", "Id", subtask.IdTask);
            return View(subtask);
        }

        // POST: Subtasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdTask,SubtaskName,IdStatus")] Subtask subtask)
        {
            if (id != subtask.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subtask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubtaskExists(subtask.Id))
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
            ViewData["IdStatus"] = new SelectList(_context.Statuses, "Id", "Id", subtask.IdStatus);
            ViewData["IdTask"] = new SelectList(_context.Tasks, "Id", "Id", subtask.IdTask);
            return View(subtask);
        }

        // GET: Subtasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subtask = await _context.Subtasks
                .Include(s => s.IdStatusNavigation)
                .Include(s => s.IdTaskNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subtask == null)
            {
                return NotFound();
            }

            return View(subtask);
        }

        // POST: Subtasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subtask = await _context.Subtasks.FindAsync(id);
            _context.Subtasks.Remove(subtask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubtaskExists(int id)
        {
            return _context.Subtasks.Any(e => e.Id == id);
        }
    }
}
