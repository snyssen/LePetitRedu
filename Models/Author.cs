using System.Collections.Generic;

namespace LePetitRedu.Models{
    public enum Sex{
        F, M, X
    }

    public class Author{
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Sex? Sex { get; set; }
        public string Nationality { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<AuthorGenre> AuthorGenres { get; set; }
    }
}