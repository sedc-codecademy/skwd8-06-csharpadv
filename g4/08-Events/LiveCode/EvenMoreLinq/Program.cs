using System;
using System.Linq;
using System.Reflection;

namespace EvenMoreLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var authorRepo = new AuthorRepo();
            var authors = authorRepo.GetAuthors();

            var result = authors.SelectMany(a => a.Books).GroupBy(b => b.ID).Where(g => g.Count() > 1);

            foreach (var duplicates in result)
            {
                foreach (var book in duplicates)
                {
                    Console.WriteLine(book);
                }
            }

            //Random r = new Random();

            //var randomHalf = authors.Where(_ => r.NextDouble() > 0.5);

            //Console.WriteLine(authors.Count());
            //Console.WriteLine(randomHalf.Count());

            var totalBooks = authors.SelectMany(a => a.Books).Distinct(new BookComparer());

            var bookIds = authors.SelectMany(a => a.Books).Select(b => b.ID).Distinct();

            Console.WriteLine(totalBooks.Count());
            Console.WriteLine(bookIds.Count());

            var doubles = totalBooks.Where(b => b.ID == 21358);
            Console.WriteLine(doubles.Count());

            foreach (var book in doubles)
            {
                Console.WriteLine(book);
            }

            totalBooks
                //.Select((b, index)=> (Index:index+1, Title:b.Title, ID: b.ID ))
                .Select((b, index) => (Index: index+1, b.Title, b.ID))
                .Print(item => $"{item.Index}. {item.Title} ({item.ID})");

            //  Name (ID)
            //  Name (ID)
            //  Name (ID)
            //

            //  1. Name (ID)
            //  2. Name (ID)
            //  3. Name (ID)
            //

        }
    }
}
