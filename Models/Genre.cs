using System.Collections.Generic;

namespace LePetitRedu.Models{
    public class Genre{
        public int GenreId { get; set; }
        public string Name { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<AuthorGenre> AuthorGenres { get; set; }
    }
}