using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EvenMoreLinq
{
    internal class Book
    {
        public int ID { get; internal set; }
        public string Title { get; internal set; }
        public int Year { get; internal set; }
        public BookType Type { get; internal set; }
        public int Nominations { get; internal set; }
        public int Wins { get; internal set; }
        public Genre[] Genres { get; internal set; }

        public override string ToString()
        {
            return $"{ID}: {Title}";
        }
    }

    internal class BookComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book first, Book second)
        {
            return first.ID == second.ID; 
        }

        public int GetHashCode(Book book)
        {
            return book.ID.GetHashCode();
        }
    }
}