using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthorsCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveAuthors().Wait();
        }

        private static async Task SaveBooks()
        {
            var artemis = new Book
            {
                ID = 25361,
                Title = "Artemis:  A Novel",
                Year = 2017,
                Type = BookType.Novel,
                Nominations = 1,
                ImageName = "AW_artemis.jpg",
                Wins = 0,
                Genres = new Genre[] { Genre.ScienceFiction }
            };

            await SedcSerialization.SerializeToFile(artemis, "andy-weir-artemis-auto.ssf");

            var martian = new Book
            {
                ID = 8279,
                Title = "The Martian",
                Year = 2011,
                Type = BookType.Novel,
                Nominations = 0,
                ImageName = "aw_themarti.jpg",
                Wins = 0,
                Genres = new Genre[] { Genre.ScienceFiction }
            };

            await SedcSerialization.SerializeToFile(martian, "andy-weir-martian-auto.ssf");


            var randomize = new Book
            {
                ID = 36075,
                Title = "Randomize",
                Year = 2019,
                Type = BookType.ShortStory,
                Nominations = 0,
                ImageName = "AW_randomiz.jpg",
                Wins = 0,
                Genres = new Genre[] { Genre.ScienceFiction }
            };

            await SedcSerialization.SerializeToFile(randomize, "andy-weir-randomize-auto.ssf");

        }

        private static async Task SaveAuthors()
        {
            var artemis = new Book
            {
                ID = 25361,
                Title = "Artemis:  A Novel",
                Year = 2017,
                Type = BookType.Novel,
                Nominations = 1,
                ImageName = "AW_artemis.jpg",
                Wins = 0,
                Genres = new Genre[] { Genre.ScienceFiction }
            };

            var martian = new Book
            {
                ID = 8279,
                Title = "The Martian",
                Year = 2011,
                Type = BookType.Novel,
                Nominations = 0,
                ImageName = "aw_themarti.jpg",
                Wins = 0,
                Genres = new Genre[] { Genre.ScienceFiction }
            };

            var randomize = new Book
            {
                ID = 36075,
                Title = "Randomize",
                Year = 2019,
                Type = BookType.ShortStory,
                Nominations = 0,
                ImageName = "AW_randomiz.jpg",
                Wins = 0,
                Genres = new Genre[] { Genre.ScienceFiction }
            };

            var andyWeir = new Author
            {
                ID = 2220,
                Name = "Andy Weir",
                Nominations = 2,
                Wins = 0,
                Books = new List<Book> {  martian, artemis, randomize }
            };

            await SedcSerialization.SerializeToFile(andyWeir.Books, "andy-weir-books-auto.ssf");
            await SedcSerialization.SerializeToFile(andyWeir, "andy-weir-auto.ssf");

            var swallow = new Author
            {
                ID = 1512,
                Name = "James Swallow",
                Nominations = 0,
                Wins = 0,
                Books = new List<Book>()
            };

            await SedcSerialization.SerializeToFile(swallow, "swallow-auto.ssf");
        }

        private static async Task LoadAuthor()
        {
            var andyWeir = SedcSerialization.DeserializeFromFile("andy-weir-auto.ssf").Result;

            Console.WriteLine(andyWeir?.Name);
            Console.WriteLine(andyWeir?.Nominations);
        }
    }
}
