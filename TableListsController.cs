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
    public class TableListsController : Controller
    {
        private readonly matedbContext _context;

        public TableListsController(matedbContext context)
        {
            _context = context;
        }

        // GET: TableLists
        public async Task<IActionResult> Index()
        {
            var matedbContext = _context.Lists.Include(t => t.Users);
            return View(await matedbContext.ToListAsync());
        }

        // GET: TableLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableList = await _context.Lists
                .Include(t => t.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableList == null)
            {
                return NotFound();
            }

            return View(tableList);
        }

        // GET: TableLists/Create
        public IActionResult Create()
        {
            ViewData["UsersId"] = new SelectList(_context.UsersInfos, "Id", "UserLogin");
            return View();
        }

        // POST: TableLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Listname,DefaultList,Hobby,UsersId")] TableList tableList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsersId"] = new SelectList(_context.UsersInfos, "Id", "UserLogin", tableList.UsersId);
            return View(tableList);
        }

        // GET: TableLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableList = await _context.Lists.FindAsync(id);
            if (tableList == null)
            {
                return NotFound();
            }
            ViewData["UsersId"] = new SelectList(_context.UsersInfos, "Id", "UserLogin", tableList.UsersId);
            return View(tableList);
        }

        // POST: TableLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Listname,DefaultList,Hobby,UsersId")] TableList tableList)
        {
            if (id != tableList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableListExists(tableList.Id))
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
            ViewData["UsersId"] = new SelectList(_context.UsersInfos, "Id", "UserLogin", tableList.UsersId);
            return View(tableList);
        }

        // GET: TableLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableList = await _context.Lists
                .Include(t => t.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableList == null)
            {
                return NotFound();
            }

            return View(tableList);
        }

        // POST: TableLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableList = await _context.Lists.FindAsync(id);
            _context.Lists.Remove(tableList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableListExists(int id)
        {
            return _context.Lists.Any(e => e.Id == id);
        }
    }
}
