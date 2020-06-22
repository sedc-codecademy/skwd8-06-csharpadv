using System;
using System.Linq;

namespace Authors
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new AuthorRepo();

            var authors = source.GetAuthors().Count();

            Console.WriteLine(authors);
        }
    }
}
