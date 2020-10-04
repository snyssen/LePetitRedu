using System.Collections.Generic;

namespace LePetitRedu.Models{
    public class Serie{
        public int SerieId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}