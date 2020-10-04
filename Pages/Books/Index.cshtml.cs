using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LePetitRedu.Data;
using LePetitRedu.Models;

namespace LePetitRedu.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly LePetitRedu.Data.LibraryContext _context;

        public IndexModel(LePetitRedu.Data.LibraryContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books
                .Include(b => b.Serie).ToListAsync();
        }
    }
}
