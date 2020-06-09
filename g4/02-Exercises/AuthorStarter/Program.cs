using System;
using System.Linq;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();
            Console.WriteLine($"There are {authors.Count()} total authors");
            Console.WriteLine($"with {authors.SelectMany(a => a.Books).Count()} total books");

            Console.WriteLine("How many books are collaborations (have more than one author)?");
            Console.WriteLine("Which book has the most authors (and how many)?");
            Console.WriteLine("What author wrote most collaborations?");
        }
    }
}
