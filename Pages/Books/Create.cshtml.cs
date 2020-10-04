using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LePetitRedu.Data;
using LePetitRedu.Models;

namespace LePetitRedu.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly LePetitRedu.Data.LibraryContext _context;

        public CreateModel(LePetitRedu.Data.LibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["SerieId"] = new SelectList(_context.Set<Serie>(), "SerieId", "SerieId");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
