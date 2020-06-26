using System.Collections.Generic;

namespace EvenMoreLinq
{
    public class Author
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public int Nominations { get; internal set; }
        public int Wins { get; internal set; }
        internal List<Book> Books { get; set; }
    }
}