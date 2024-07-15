using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MateTest2.MateT1;

namespace MateTest2.Pages.MateView
{
    public class CreateModel : PageModel
    {
        private readonly MateTest2.MateT1.matedbContext _context;

        public CreateModel(MateTest2.MateT1.matedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UsersId"] = new SelectList(_context.UsersInfos, "Id", "UserLogin");
            return Page();
        }

        [BindProperty]
        public TableList List { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lists.Add(List);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
