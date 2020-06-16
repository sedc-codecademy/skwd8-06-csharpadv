using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Author : IBasicEntity
    {
        public int ID { get; set; }
    }

    public class AuthorManager
    {
        public Author GetAuthorByID(int id)
        {
            return null;
        }

        public int SaveAuthor(Author author)
        {
            return 0;
        }

        public bool DeleteAuthor(Author author)
        {
            return true;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return new List<Author>();
        }
    }
}
