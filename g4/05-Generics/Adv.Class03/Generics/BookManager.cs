using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{

    public class Book : IBasicEntity
    {
        public int ID { get; set; }

        public override string ToString()
        {
            return $"Book #{ID}";
        }
    }

    public class BookManager
    {
        public Book GetBookByID(int id)
        {
            return null;
        }

        public int SaveBook(Book book)
        {
            return 0;
        }

        public bool DeleteBook(Book book)
        {
            return true;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>();
        }
    }
}
