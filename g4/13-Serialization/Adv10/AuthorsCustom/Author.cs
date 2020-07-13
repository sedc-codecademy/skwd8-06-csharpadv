using System.Collections.Generic;

namespace AuthorsCustom
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Nominations { get; set; }
        public int Wins { get; set; }

        [SsfInclude]
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return $"#{ID}: {Name}";
        }
    }
}