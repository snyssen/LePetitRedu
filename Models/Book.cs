using System.Collections.Generic;

namespace LePetitRedu.Models{
    public enum ReadStatus{
        Yes, No, InProgress
    }
    public class Book{
        public int BookId { get; set; }
        public string Title { get; set; }
        public int ParutionDate { get; set; }
        public string Format { get; set; }
        public int SerieId { get; set; }

        //Idée à faire avec la mise à jour pour intégrer les users et l'autentification :
        //créer une table de liaison BookUser avec les champs Read, Possessed, liked en plus
        public ReadStatus? Read { get; set; }
        public bool Possessed { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }

        public Serie Serie { get; set; }
    }
}