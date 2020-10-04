using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LePetitRedu.Models;

namespace LePetitRedu.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<LePetitRedu.Models.Author> Authors { get; set; }
        public DbSet<LePetitRedu.Models.AuthorGenre> AuthorGenres { get; set; }
        public DbSet<LePetitRedu.Models.Book> Books { get; set; }
        public DbSet<LePetitRedu.Models.BookAuthor> BookAuthors { get; set; }
        public DbSet<LePetitRedu.Models.BookGenre> BookGenres { get; set; }
        public DbSet<LePetitRedu.Models.Genre> Genres { get; set; }
        public DbSet<LePetitRedu.Models.Serie> Series { get; set; }
    }
}
