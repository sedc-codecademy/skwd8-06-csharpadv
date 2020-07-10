using System;
using System.Collections.Generic;

namespace AuthorsCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            var andyWeir = new Author
            {
                ID = 2220,
                Name = "Andy Weir",
                Nominations = 2,
                Wins = 0,
                Books = new List<Book>()
            };

            SedcSerialization.SerializeToFile(andyWeir, "andy-weir-auto.ssf");

            var swallow = new Author
            {
                ID = 1512,
                Name = "James Swallow",
                Nominations = 0,
                Wins = 0,
                Books = new List<Book>()
            };

            SedcSerialization.SerializeToFile(swallow, "swallow-auto.ssf");


            //var artemis = new Book
            //{
            //    ID = 25361,
            //    Title = "Artemis:  A Novel",
            //    Year = 2017,
            //    Type = BookType.Novel,
            //    Nominations = 1,
            //    ImageName = "AW_artemis.jpg",
            //    Wins = 0,
            //    Genres = new Genre[] { Genre.ScienceFiction }
            //};

            //var martian = new Book
            //{
            //    ID = 8279,
            //    Title = "The Martian",
            //    Year = 2011,
            //    Type = BookType.Novel,
            //    Nominations = 0,
            //    ImageName = "aw_themarti.jpg",
            //    Wins = 0,
            //    Genres = new Genre[] { Genre.ScienceFiction }
            //};

            //var randomize = new Book
            //{
            //    ID = 36075,
            //    Title = "Randomize",
            //    Year = 2019,
            //    Type = BookType.ShortStory,
            //    Nominations = 0,
            //    ImageName = "AW_randomiz.jpg",
            //    Wins = 0,
            //    Genres = new Genre[] { Genre.ScienceFiction }
            //};

            //andyWeir.Books.Add(artemis);
            //andyWeir.Books.Add(martian);
            //andyWeir.Books.Add(randomize);



        }
    }
}
