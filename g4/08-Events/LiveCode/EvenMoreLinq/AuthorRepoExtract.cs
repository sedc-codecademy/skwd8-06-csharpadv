using System;
using System.Collections.Generic;
using System.Text;

namespace EvenMoreLinq
{
    class AuthorRepo
    {

        public List<Author> GetAuthors()
        {
            return new List<Author>
            {
                new Author
                {
                    ID = 32,
                    Name = "David Brin",
                    Nominations = 24,
                    Wins = 7,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21951,
                            Title = "Chasing Shadows:  Visions of Our Coming Transparent World",
                            Year = 2017,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 17307,
                            Title = "Insistence of Vision",
                            Year = 2016,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27588,
                            Title = "The Tumbledowns of Cleopatra Abyss",
                            Year = 2015,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3802,
                            Title = "Existence",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35676,
                            Title = "Sky Horizon",
                            Year = 2007,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4153,
                            Title = "Contacting Aliens: An Illustrated Guide to David Brin's Uplift Universe",
                            Year = 2002,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 59,
                            Title = "Kiln People",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32702,
                            Title = "Reality Check",
                            Year = 2000,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3804,
                            Title = "Otherness",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 94,
                            Title = "Glory Season",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10233,
                            Title = "Murasaki",
                            Year = 1992,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 105,
                            Title = "Earth",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23945,
                            Title = "Piecework",
                            Year = 1990,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25443,
                            Title = "Project Solar Sail",
                            Year = 1990,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23946,
                            Title = "Dr. Pak's Preschool",
                            Year = 1989,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21378,
                            Title = "The Giving Plague",
                            Year = 1988,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 762,
                            Title = "Heart of the Comet",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3803,
                            Title = "The River of Time",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21018,
                            Title = "Thor Meets Captain America",
                            Year = 1986,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 207,
                            Title = "The Postman",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21382,
                            Title = "The Crystal Spheres",
                            Year = 1984,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20668,
                            Title = "Cyclops",
                            Year = 1984,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3728,
                            Title = "The Practice Effect",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20815,
                            Title = "The Postman",
                            Year = 1982,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3267,
                            Title = "Foundation's Triumph",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1281,
                            Title = "Sundiver",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31,
                            Title = "Startide Rising",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 3,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35,
                            Title = "The Uplift War",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 85,
                            Title = "Brightness Reef",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1282,
                            Title = "Infinity's Shore",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1283,
                            Title = "Heaven's Reach",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32813,
                            Title = "Life in the Extreme",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 42,
                    Name = "Kim Stanley Robinson",
                    Nominations = 50,
                    Wins = 10,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28530,
                            Title = "Red Moon",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21480,
                            Title = "New York 2140",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11037,
                            Title = "Aurora",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16304,
                            Title = "Oral Argument",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8681,
                            Title = "Green Planets: Ecology and Science Fiction",
                            Year = 2014,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5775,
                            Title = "Shaman",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3883,
                            Title = "2312",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 6,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6921,
                            Title = "The Best of Kim Stanley Robinson",
                            Year = 2010,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1708,
                            Title = "Galileo's Dream",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13959,
                            Title = "Vinland the Dream and Other Stories",
                            Year = 2002,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 61,
                            Title = "The Years of Rice and Salt",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27393,
                            Title = "A Martian Romance",
                            Year = 1999,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 709,
                            Title = "Antarctica",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7396,
                            Title = "Future Primitive:  The New Ecotopias",
                            Year = 1994,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13961,
                            Title = "Remaking History and Other Stories",
                            Year = 1994,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13960,
                            Title = "Down and Out in the Year 2000",
                            Year = 1992,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26230,
                            Title = "A History of the Twentieth Century, with Illustrations",
                            Year = 1991,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24296,
                            Title = "Remaking History",
                            Year = 1991,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17696,
                            Title = "Vinland the Dream",
                            Year = 1991,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6215,
                            Title = "A Short, Sharp Shock",
                            Year = 1990,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17648,
                            Title = "Before I Wake",
                            Year = 1989,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6214,
                            Title = "Escape from Kathmandu (collection)",
                            Year = 1989,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27758,
                            Title = "Glacier",
                            Year = 1988,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16801,
                            Title = "The Lunatics",
                            Year = 1988,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31693,
                            Title = "Remaking History",
                            Year = 1988,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20514,
                            Title = "Mother Goddess of the World",
                            Year = 1987,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19258,
                            Title = "The Blind Geometer",
                            Year = 1986,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26846,
                            Title = "Down and Out in the Year 2000",
                            Year = 1986,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19260,
                            Title = "Escape from Kathmandu",
                            Year = 1986,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22469,
                            Title = "Our Town",
                            Year = 1986,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10889,
                            Title = "The Planet on the Table",
                            Year = 1986,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 650,
                            Title = "The Memory of Whiteness",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17193,
                            Title = "Mercurial",
                            Year = 1985,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6213,
                            Title = "Icehenge",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18489,
                            Title = "The Lucky Strike",
                            Year = 1984,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17725,
                            Title = "Ridge Running",
                            Year = 1984,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16305,
                            Title = "Black Air",
                            Year = 1983,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20510,
                            Title = "To Leave a Mark",
                            Year = 1982,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17698,
                            Title = "Venice Drowned",
                            Year = 1981,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28279,
                            Title = "A Sensitive Dependence on Initial Conditions",
                            Year = 1991,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14168,
                            Title = "Green Earth",
                            Year = 2015,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 673,
                            Title = "Forty Signs of Rain",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 846,
                            Title = "Fifty Degrees Below",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1292,
                            Title = "Sixty Days and Counting",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6497,
                            Title = "The Martians",
                            Year = 1999,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16121,
                            Title = "Sexual Dimorphism",
                            Year = 1999,
                            Type = BookType.ShortStory,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19259,
                            Title = "Green Mars",
                            Year = 1985,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 98,
                            Title = "Red Mars",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 6,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 41,
                            Title = "Green Mars",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 44,
                            Title = "Blue Mars",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 5,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7373,
                            Title = "Nebula Awards Showcase 2002",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7737,
                            Title = "The Lucky Strike (collection)",
                            Year = 2009,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 214,
                            Title = "The Wild Shore",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 432,
                            Title = "The Gold Coast",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 429,
                            Title = "Pacific Edge",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11083,
                            Title = "Tor Double #1: A Meeting With Medusa / Green Mars",
                            Year = 1988,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11119,
                            Title = "Tor Double #13: The Blind Geometer / The New Atlantis",
                            Year = 1989,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11099,
                            Title = "Tor Double #28: A Short Sharp Shock / The Dragon Masters",
                            Year = 1990,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 44,
                    Name = "Neal Stephenson",
                    Nominations = 28,
                    Wins = 8,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32413,
                            Title = "Fall, or Dodge in Hell",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23389,
                            Title = "The Rise and Fall of D.O.D.O.",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11036,
                            Title = "Seveneves:  A Novel",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34170,
                            Title = "Atmosphaera Incognita",
                            Year = 2013,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7269,
                            Title = "Some Remarks:  Essays and Other Writings",
                            Year = 2012,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4229,
                            Title = "Reamde",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1216,
                            Title = "Anathem",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 5,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 71,
                            Title = "Cryptonomicon",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1088,
                            Title = "Interface",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 43,
                            Title = "The Diamond Age",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 6,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 617,
                            Title = "Snow Crash",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2576,
                            Title = "Zodiac",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 579,
                            Title = "Quicksilver",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1328,
                            Title = "The Confusion",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 578,
                            Title = "The System of the World",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4717,
                            Title = "The Mongoliad:  Book One",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4718,
                            Title = "The Mongoliad:  Book Two",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4719,
                            Title = "The Mongoliad:  Book Three",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 51,
                    Name = "Robert J. Sawyer",
                    Nominations = 40,
                    Wins = 11,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36067,
                            Title = "The Oppenheimer Alternative",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16452,
                            Title = "Quantum Night",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4716,
                            Title = "Red Planet Blues",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3886,
                            Title = "Triggers",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12113,
                            Title = "Identity Theft: And Other Stories",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1037,
                            Title = "Rollback",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19453,
                            Title = "Identity Theft",
                            Year = 2005,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 858,
                            Title = "Mindscan",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21310,
                            Title = "Shed Skin",
                            Year = 2002,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 67,
                            Title = "Calculating God",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32807,
                            Title = "The Blue Planet",
                            Year = 1999,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1261,
                            Title = "Flashforward",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1824,
                            Title = "Golden Fleece",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 76,
                            Title = "Factoring Humanity",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 78,
                            Title = "Frameshift",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21661,
                            Title = "The Hand You're Dealt",
                            Year = 1997,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12112,
                            Title = "Illegal Alien",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 84,
                            Title = "Starplex",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 163,
                            Title = "The Terminal Experiment",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 2,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12111,
                            Title = "End of an Era",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 50,
                            Title = "Hominids",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 55,
                            Title = "Humans",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1259,
                            Title = "Hybrids",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1834,
                            Title = "Far-Seer",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2434,
                            Title = "Fossil Hunter",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2435,
                            Title = "Foreigner",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1260,
                            Title = "WWW: Wake",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2208,
                            Title = "WWW: Watch",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2209,
                            Title = "WWW: Wonder",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 61,
                    Name = "China Mi├⌐ville",
                    Nominations = 42,
                    Wins = 16,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18573,
                            Title = "The Last Days of New Paris",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16278,
                            Title = "This Census-Taker",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12866,
                            Title = "Three Moments of an Explosion: Stories",
                            Year = 2015,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3828,
                            Title = "Railsea",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2534,
                            Title = "Embassytown",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 7,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2095,
                            Title = "Kraken",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1674,
                            Title = "The City & the City",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 8,
                            Wins = 6,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2533,
                            Title = "Un Lun Dun",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5758,
                            Title = "Looking for Jake: Stories",
                            Year = 2005,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24127,
                            Title = "Reports of Certain Events in London",
                            Year = 2004,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16279,
                            Title = "The Tain",
                            Year = 2002,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5757,
                            Title = "King Rat",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10605,
                            Title = "Red Planets: Marxism and Science Fiction",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 66,
                            Title = "Perdido Street Station",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 7,
                            Wins = 2,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 60,
                            Title = "The Scar",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 7,
                            Wins = 2,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 572,
                            Title = "Iron Council",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 4,
                            Wins = 2,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 154,
                    Name = "Nina Kiriki Hoffman",
                    Nominations = 9,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30178,
                            Title = "Rings",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22555,
                            Title = "Monster, Finder, Shifter",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18670,
                            Title = "Permeable Borders",
                            Year = 2012,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16492,
                            Title = "Ghost Hedgehog",
                            Year = 2011,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25662,
                            Title = "Futures in the Memories Market",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17687,
                            Title = "Trophy Wives",
                            Year = 2008,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 996,
                            Title = "Catalyst: A Novel of Alien Contact",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18680,
                            Title = "Time Travelers, Ghosts, and Other Visitors",
                            Year = 2003,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18669,
                            Title = "Home for Christmas",
                            Year = 1995,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18681,
                            Title = "The Skeleton Key",
                            Year = 1993,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7303,
                            Title = "Child of an Ancient City",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24612,
                            Title = "Courting Disasters and Other Strange Affinities",
                            Year = 1991,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28273,
                            Title = "Legacy of Fire",
                            Year = 1990,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 733,
                            Title = "The Thread That Binds the Bone",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 161,
                            Title = "The Silent Strength of Stones",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3645,
                            Title = "Spirits That Walk in Shadow",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19325,
                            Title = "Haunted Humans",
                            Year = 1994,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3653,
                            Title = "A Stir of Bones",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 884,
                            Title = "A Red Heart of Memories",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25972,
                            Title = "Past the Size of Dreaming",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5664,
                            Title = "A Fistful of Sky",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2595,
                            Title = "Thresholds",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21739,
                            Title = "Unmasking",
                            Year = 1992,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20008,
                            Title = "Echoes",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 222,
                    Name = "A. A. Attanasio",
                    Nominations = 4,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34014,
                            Title = "The Conjure Book",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34017,
                            Title = "Killing with the Edge of the Moon",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34019,
                            Title = "Twice Dead Things",
                            Year = 2006,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 34015,
                            Title = "Centuries",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11681,
                            Title = "Solis",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34013,
                            Title = "The Moon's Wife",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34018,
                            Title = "Kingdom Of The Grail",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 916,
                            Title = "Hunting the Ghost Dancer",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6974,
                            Title = "Wyvern ",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24514,
                            Title = "Beastmarks",
                            Year = 1985,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6968,
                            Title = "The Dragon and the Unicorn ",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6969,
                            Title = "The Eagle and the Sword",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6970,
                            Title = "The Wolf and the Crown",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6972,
                            Title = "The Serpent and the Grail ",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 228,
                            Title = "Radix",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6963,
                            Title = "In Other Worlds ",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6965,
                            Title = "Arc of the Dream",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6967,
                            Title = "The Last Legends of Earth ",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 240,
                    Name = "David Gerrold",
                    Nominations = 8,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36015,
                            Title = "Hella",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27892,
                            Title = "The Further Adventures of Mr. Costello",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19901,
                            Title = "The Involuntary Human",
                            Year = 2007,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 860,
                            Title = "Child of Earth",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27076,
                            Title = "In the Quake Zone",
                            Year = 2005,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19902,
                            Title = "Dancer in the Dark",
                            Year = 2004,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18683,
                            Title = "The Martian Child:  A Novel About a Single Father Adopting a Son (Based on a True Story)",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18684,
                            Title = "The Martian Child",
                            Year = 1994,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26957,
                            Title = "Chess with a Dragon",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13427,
                            Title = "Enemy Mine",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26956,
                            Title = "Deathbeast",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34529,
                            Title = "Ascents of Wonder",
                            Year = 1977,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 246,
                            Title = "Moonstar Odyssey",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34528,
                            Title = "Alternities",
                            Year = 1974,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19419,
                            Title = "Science Fiction Emphasis 1",
                            Year = 1974,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 274,
                            Title = "The Man Who Folded Himself",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19012,
                            Title = "In the Deadlands",
                            Year = 1972,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26958,
                            Title = "Space Skimmer",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 282,
                            Title = "When Harlie Was One",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19011,
                            Title = "With a Finger in My I",
                            Year = 1972,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8690,
                            Title = "The Flying Sorcerers",
                            Year = 1971,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18174,
                            Title = "Protostars",
                            Year = 1971,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11626,
                            Title = "The Galactic Whirlpool",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19432,
                            Title = "Jumping Off the Planet",
                            Year = 1998,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7028,
                            Title = "Jumping Off the Planet",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7029,
                            Title = "Bouncing Off the Moon",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7030,
                            Title = "Leaping to the Stars ",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17044,
                            Title = "Battle for the Planet of the Apes",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10624,
                            Title = "Encounter at Farpoint",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9150,
                            Title = "Starhunt (Yesterday's Children)",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9147,
                            Title = "The Voyage of the Star Wolf",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9148,
                            Title = "The Middle of Nowhere",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9149,
                            Title = "Blood and Fire",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26959,
                            Title = "Under the Eye of God",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26960,
                            Title = "A Covenant of Justice",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17140,
                            Title = "A Matter for Men",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17141,
                            Title = "A Day for Damnation",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17142,
                            Title = "A Rage for Revenge",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17143,
                            Title = "A Season for Slaughter",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 362,
                    Name = "Donald Kingsbury",
                    Nominations = 4,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12005,
                            Title = "Psychohistorical Crisis",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20818,
                            Title = "The Moon Goddess and the Son",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20819,
                            Title = "The Moon Goddess and the Son",
                            Year = 1979,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 365,
                            Title = "Courtship Rite",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34212,
                            Title = "Shipwright",
                            Year = 1978,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 385,
                    Name = "Linda Nagata",
                    Nominations = 5,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24306,
                            Title = "The Last Good Man",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24638,
                            Title = "The Martian Obelisk",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28217,
                            Title = "Light and Shadow: Eight Short Stories",
                            Year = 2016,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23084,
                            Title = "The Way Home",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22541,
                            Title = "A Moment Before It Struck",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 387,
                            Title = "Memory",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13883,
                            Title = "Limit of Vision",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19470,
                            Title = "Goddesses",
                            Year = 2000,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4214,
                            Title = "The Bohr Maker",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4215,
                            Title = "Deception Well",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2821,
                            Title = "Vast",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4216,
                            Title = "Tech-Heaven",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32360,
                            Title = "Edges",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35458,
                            Title = "Silver",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22865,
                            Title = "Codename: Delphi",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22190,
                            Title = "Nightside on Callisto",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6117,
                            Title = "The Red: First Light",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11659,
                            Title = "The Trials",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14169,
                            Title = "Going Dark",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 29064,
                            Title = "Out in the Dark",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19803,
                            Title = "Nahiku West",
                            Year = 2012,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 394,
                    Name = "John C. Wright",
                    Nominations = 4,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 7869,
                            Title = "Awake in the Night Land",
                            Year = 2014,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26952,
                            Title = "Twilight of the Gods",
                            Year = 2009,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27329,
                            Title = "Awake in the Night",
                            Year = 2003,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34032,
                            Title = "Guest Law",
                            Year = 1997,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 840,
                            Title = "Orphans of Chaos",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1334,
                            Title = "Fugitives of Chaos",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1335,
                            Title = "Titans of Chaos",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25986,
                            Title = "The Last Guardian of Everness",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25987,
                            Title = "Mists of Everness",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3923,
                            Title = "Count to a Trillion",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4899,
                            Title = "The Hermetic Millennia",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7311,
                            Title = "Judge of Ages",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20544,
                            Title = "The Architect of Aeons",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20545,
                            Title = "The Vindication of Man",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26582,
                            Title = "Count to Infinity",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 396,
                            Title = "The Golden Age",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1332,
                            Title = "The Phoenix Exultant",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1333,
                            Title = "The Golden Transcendence",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 481,
                    Name = "Jamil Nasir",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13491,
                            Title = "Tunnel Out of Death",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13494,
                            Title = "The Houses of Time",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4415,
                            Title = "Distance Haze",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 482,
                            Title = "Tower of Dreams",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13493,
                            Title = "The Higher Space",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13492,
                            Title = "Quasar",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 535,
                    Name = "Susan Shwartz",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28700,
                            Title = "Hostile Takeover",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17956,
                            Title = "Suppose They Gave a Peace and Other Stories",
                            Year = 2002,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28696,
                            Title = "Second Chances",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19729,
                            Title = "Bibi",
                            Year = 1995,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18694,
                            Title = "Suppose They Gave a PeaceΓÇª",
                            Year = 1992,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18734,
                            Title = "Getting Real",
                            Year = 1991,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5647,
                            Title = "The Grail of Hearts",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18745,
                            Title = "Loose Cannon",
                            Year = 1990,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 536,
                            Title = "Heritage of Flight",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25911,
                            Title = "Silk Roads and Shadows",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17957,
                            Title = "Temple to a Minor Goddess",
                            Year = 1987,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35052,
                            Title = "Moonsinger's Friends",
                            Year = 1985,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24842,
                            Title = "Habitats",
                            Year = 1984,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32481,
                            Title = "Hecate's Cauldron",
                            Year = 1982,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28690,
                            Title = "Byzantium's Crown",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28692,
                            Title = "The Woman of Flowers",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28694,
                            Title = "Queensblade",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13231,
                            Title = "Imperial Lady",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13232,
                            Title = "Empire of the Eagle",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28702,
                            Title = "Shards of Empire",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28704,
                            Title = "Cross and Crescent",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34967,
                            Title = "Sisters in Fantasy",
                            Year = 1995,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34968,
                            Title = "Sisters in Fantasy 2",
                            Year = 1996,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16957,
                            Title = "Vulcan's Forge",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16958,
                            Title = "Vulcan's Heart",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16989,
                            Title = "Vulcan's Soul",
                            Year = 2007,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16982,
                            Title = "Exodus",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16983,
                            Title = "Exiles",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16984,
                            Title = "Epiphany",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 569,
                    Name = "Steve Rasnic Tem",
                    Nominations = 5,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28614,
                            Title = "Figures Unseen:  Selected Stories",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 22414,
                            Title = "Ubo",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6484,
                            Title = "Blood Kin",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23854,
                            Title = "Celestial Inventories",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28660,
                            Title = "Domestic Magic",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19851,
                            Title = "A Letter from the Emperor",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4563,
                            Title = "The Man on the Ceiling",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 31780,
                            Title = "Invisible",
                            Year = 2005,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21763,
                            Title = "The Man on the Ceiling",
                            Year = 2000,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9340,
                            Title = "Excavation",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23853,
                            Title = "Firestorm",
                            Year = 1982,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 570,
                            Title = "The Umbral Anthology of Science Fiction Poetry",
                            Year = 1982,
                            Type = BookType.Anthology,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27446,
                            Title = "Twember",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 822,
                    Name = "Walter Tevis",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33867,
                            Title = "The Steps of the Sun",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24506,
                            Title = "Far From Home",
                            Year = 1981,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 820,
                            Title = "Mockingbird",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3392,
                            Title = "The Man Who Fell to Earth",
                            Year = 1963,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 893,
                    Name = "Harvey Jacobs",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 891,
                            Title = "American Goliath",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 896,
                    Name = "Patrick O'Leary",
                    Nominations = 3,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9802,
                            Title = "The Impossible Bird",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24362,
                            Title = "Other Voices, Other Doors",
                            Year = 2000,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 894,
                            Title = "The Gift",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9788,
                            Title = "Door Number Three",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 952,
                    Name = "Ramsey Campbell",
                    Nominations = 21,
                    Wins = 7,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9661,
                            Title = "Think Yourself Lucky",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 8594,
                            Title = "Holes for Faces",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 5608,
                            Title = "The Kind Folk",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13387,
                            Title = "Ghosts Know",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1872,
                            Title = "Creatures of the Pool",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1243,
                            Title = "Thieving Fear",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1200,
                            Title = "The Grin of the Dark",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1192,
                            Title = "Secret Story",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24984,
                            Title = "Gathering the Bones: Thirty-Four Original Stories from the World's Masters of Horror",
                            Year = 2003,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1179,
                            Title = "The Darkest Part of the Woods",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 32111,
                            Title = "Pact of the Fathers",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1175,
                            Title = "Silent Children",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1157,
                            Title = "Nazareth Hill",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4593,
                            Title = "Alone with the Horrors",
                            Year = 1993,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1142,
                            Title = "The Long Lost",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1139,
                            Title = "The Count of Eleven",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26886,
                            Title = "The Same in Any Language",
                            Year = 1991,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1138,
                            Title = "Midnight Sun",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26075,
                            Title = "Ancient Images",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1137,
                            Title = "The Influence",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12395,
                            Title = "Dark Feasts: The World of Ramsey Campbell",
                            Year = 1987,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23806,
                            Title = "Scared Stiff: Tales of Sex and Death",
                            Year = 1987,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1136,
                            Title = "The Hungry Moon",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 27000,
                            Title = "Obsession",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1135,
                            Title = "Incarnate",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23803,
                            Title = "Dark Companions",
                            Year = 1982,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 949,
                            Title = "The Nameless",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 11206,
                            Title = "New Tales of the Cthulhu Mythos",
                            Year = 1980,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1127,
                            Title = "To Wake the Dead",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23830,
                            Title = "Mackintosh Willy",
                            Year = 1979,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23802,
                            Title = "The Chimney",
                            Year = 1977,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23805,
                            Title = "Loveman's Comeback",
                            Year = 1977,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 23780,
                            Title = "The Companion",
                            Year = 1976,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 971,
                            Title = "The Doll Who Ate His Mother",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4605,
                            Title = "The Mammoth Book of Best New Horror",
                            Year = 1990,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4761,
                            Title = "The Mammoth Book of Best New Horror 2",
                            Year = 1991,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4762,
                            Title = "The Mammoth Book of Best New Horror 3",
                            Year = 1992,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4763,
                            Title = "The Mammoth Book of Best New Horror 4",
                            Year = 1993,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4764,
                            Title = "The Mammoth Book of Best New Horror 5",
                            Year = 1994,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10707,
                            Title = "Demons by Daylight",
                            Year = 1973,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24544,
                            Title = "The Searching Dead",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26076,
                            Title = "Born to the Dark",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 30109,
                            Title = "The Way of the Worm",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1016,
                    Name = "Sean Williams",
                    Nominations = 18,
                    Wins = 4,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25381,
                            Title = "Have Sword, Will Travel",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23354,
                            Title = "The Lives of Riley",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27392,
                            Title = "Evermore, or, The Lies That Bind",
                            Year = 1999,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3387,
                            Title = "The Resurrected Man",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11313,
                            Title = "Metal Fatigue",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23158,
                            Title = "Ghosts of the Fall",
                            Year = 1993,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1025,
                            Title = "Saturn Returns",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2233,
                            Title = "Earth Ascendant",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2234,
                            Title = "The Grand Conjunction",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4542,
                            Title = "Cenotaxis",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2235,
                            Title = "The Crooked Letter",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2236,
                            Title = "The Blood Debt",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2237,
                            Title = "The Hanging Mountains",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2238,
                            Title = "The Devoured Earth",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2253,
                            Title = "The Stone Mage & the Sea",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2254,
                            Title = "The Sky Warden & the Sun",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2255,
                            Title = "The Storm Weaver & the Sand",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11536,
                            Title = "The Unknown Soldier",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11375,
                            Title = "The Prodigal Sun",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11376,
                            Title = "The Dying Light",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11377,
                            Title = "The Dark Imbalance",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11382,
                            Title = "Ascent",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11381,
                            Title = "Descent",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11378,
                            Title = "Echoes of Earth",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11379,
                            Title = "Orphans of Earth",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11380,
                            Title = "Heirs of Earth",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17191,
                            Title = "The Force Unleashed",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17192,
                            Title = "The Force Unleashed II",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15986,
                            Title = "Remnant",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15987,
                            Title = "Refugee",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15988,
                            Title = "Reunion",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14484,
                            Title = "Fatal Alliance",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27535,
                            Title = "The Masque of Agamemnon",
                            Year = 1997,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22760,
                            Title = "Death and the Hobbyist",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22696,
                            Title = "Face Value",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22877,
                            Title = "Zero Temptation",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22651,
                            Title = "The Missing Metatarsal",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14329,
                            Title = "Jump",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14330,
                            Title = "Crash",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15918,
                            Title = "Fall",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1037,
                    Name = "John Meaney",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 1095,
                            Title = "To Hold Infinity",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28938,
                            Title = "Necroflux Day",
                            Year = 2009,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31803,
                            Title = "The Swastika Bomb",
                            Year = 2003,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27362,
                            Title = "The Whisper of Discs",
                            Year = 2002,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25988,
                            Title = "Bone Song",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25989,
                            Title = "Dark Blood",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1098,
                            Title = "Paradox",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1603,
                            Title = "Context",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1604,
                            Title = "Resolution",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2736,
                            Title = "Absorption",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4305,
                            Title = "Transmission",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31804,
                            Title = "Resonance",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1047,
                    Name = "Mark Chadbourn",
                    Nominations = 7,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 1894,
                            Title = "Lord of Silence",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1144,
                            Title = "Nocturne",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1171,
                            Title = "World's End",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1396,
                            Title = "Darkest Hour",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1177,
                            Title = "Always Forever",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1180,
                            Title = "The Devil in Green",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1188,
                            Title = "The Queen of Sinister",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1190,
                            Title = "The Hounds of Avalon",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1889,
                            Title = "The Ice Wolves",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 1198,
                            Title = "Jack of Ravens",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1429,
                            Title = "The Burning Man",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1430,
                            Title = "Destroyer of Worlds",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1924,
                            Title = "The Silver Skull",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2294,
                            Title = "The Scar-Crow Men",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4507,
                            Title = "The Devil's Looking Glass",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9129,
                            Title = "Wonderland",
                            Year = 2003,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1096,
                    Name = "Felix Gilman",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 6652,
                            Title = "The Revolutions",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16316,
                            Title = "Lightbringers and Rainmakers",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5712,
                            Title = "Thunderer",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 1713,
                            Title = "Gears of the City",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2639,
                            Title = "The Half-Made World",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6653,
                            Title = "The Rise of Ransom City",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1110,
                    Name = "Patrick Ness",
                    Nominations = 4,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30320,
                            Title = "The Rest of Us Just Live Here",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12721,
                            Title = "The Crane Wife",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9961,
                            Title = "More Than This",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4090,
                            Title = "A Monster Calls",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 2436,
                            Title = "The Knife of Never Letting Go",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1734,
                            Title = "The Ask and the Answer",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2437,
                            Title = "Monsters of Men",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1193,
                    Name = "Chris Beckett",
                    Nominations = 4,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34574,
                            Title = "Beneath the World, A Sea",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27364,
                            Title = "America City",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16824,
                            Title = "The Peacock Cloak",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27029,
                            Title = "The Peacock Cloak",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 1895,
                            Title = "Marcher",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16822,
                            Title = "The Turing Test",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27074,
                            Title = "Piccadilly Circus",
                            Year = 2005,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2726,
                            Title = "The Holy Machine",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27363,
                            Title = "To Become a Warrior ",
                            Year = 2002,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24521,
                            Title = "Marcher",
                            Year = 2001,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32723,
                            Title = "The Marriage of Sky & Sea",
                            Year = 2000,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32809,
                            Title = "Valour",
                            Year = 1999,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5026,
                            Title = "Dark Eden",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11972,
                            Title = "Mother of Eden",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20283,
                            Title = "Daughter of Eden",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27686,
                            Title = "La Macchina",
                            Year = 1991,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1234,
                    Name = "Pat Frank",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 1991,
                            Title = "Alas, Babylon",
                            Year = 1959,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1283,
                    Name = "Charlotte Perkins Gilman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27299,
                            Title = "The Yellow Wallpaper",
                            Year = 1892,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 2274,
                            Title = "Herland",
                            Year = 1915,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13869,
                            Title = "Charlotte Perkins Gilman:  Her Progress Towards Utopia and Selected Writings",
                            Year = 1995,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1288,
                    Name = "Jack London",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9152,
                            Title = "The Scarlet Plague",
                            Year = 1915,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10611,
                            Title = "The Star Rover:  A Tale of Past Lives",
                            Year = 1915,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6763,
                            Title = "The Iron Heel",
                            Year = 1908,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3615,
                            Title = "Before Adam",
                            Year = 1906,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10600,
                            Title = "Fantastic Tales",
                            Year = 1998,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2286,
                            Title = "The Science Fiction of Jack London",
                            Year = 1975,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1330,
                    Name = "K. J. Parker",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35851,
                            Title = "Prosper's Demon",
                            Year = 2020,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36272,
                            Title = "My Beautiful Life",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34097,
                            Title = "Sixteen Ways to Defend a Walled City",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 29083,
                            Title = "The Father of Lies",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23287,
                            Title = "Mightier than the Sword",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17137,
                            Title = "Downfall of the Gods",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13999,
                            Title = "The Last Witness",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13184,
                            Title = "Savages",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8743,
                            Title = "Academic Exercises",
                            Year = 2014,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30108,
                            Title = "Heaven Thunders the Truth",
                            Year = 2014,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22175,
                            Title = "I Met a Man Who Wasn't There",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 29082,
                            Title = "The Dragonslayer of Merebarton",
                            Year = 2013,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21752,
                            Title = "The Sun And I",
                            Year = 2013,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21753,
                            Title = "Let Maps to Others",
                            Year = 2012,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5494,
                            Title = "Sharps",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2580,
                            Title = "The Hammer",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21754,
                            Title = "A Small Price to Pay for Birdsong",
                            Year = 2011,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26430,
                            Title = "Amor Vincit Omnia",
                            Year = 2010,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2579,
                            Title = "The Folding Knife",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2582,
                            Title = "Purple and Black",
                            Year = 2009,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2583,
                            Title = "The Company",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2584,
                            Title = "Devices and Desires",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2585,
                            Title = "Evil for Evil",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2586,
                            Title = "The Escapement",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5495,
                            Title = "Colours in the Steel",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5497,
                            Title = "The Belly of the Bow",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5498,
                            Title = "The Proof House",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2581,
                            Title = "Blue and Gold",
                            Year = 2010,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17161,
                            Title = "The Devil You Know",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5500,
                            Title = "Shadow",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5499,
                            Title = "Pattern",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5496,
                            Title = "Memory",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1366,
                    Name = "Jennifer Kirk",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2730,
                            Title = "Bringing Home the Stars",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1401,
                    Name = "Deborah Chester",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 2837,
                            Title = "The Children of Anthi",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4293,
                            Title = "Requiem for Anthi",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7095,
                            Title = "The Pearls",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7096,
                            Title = "The Crown",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7092,
                            Title = "Reign of Shadows ",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7093,
                            Title = "Shadow War",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7094,
                            Title = "Realm of Light ",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7097,
                            Title = "The Sword",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7098,
                            Title = "The Ring",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7099,
                            Title = "The Chalice",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1427,
                    Name = "Simon Morden",
                    Nominations = 1,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35143,
                            Title = "Bright Morning Star",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22051,
                            Title = "At the Speed of Light",
                            Year = 2017,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9567,
                            Title = "Arcanum",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5527,
                            Title = "The Curve of The Earth",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21762,
                            Title = "Another War",
                            Year = 2005,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34264,
                            Title = "Macsen Against the Jugger",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19486,
                            Title = "Down Station",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20682,
                            Title = "The White City",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 2994,
                            Title = "Equations of Life",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2995,
                            Title = "Theories of Flight",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 2996,
                            Title = "Degrees of Freedom",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1453,
                    Name = "Alan Garner",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3116,
                            Title = "Red Shift",
                            Year = 1973,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4348,
                            Title = "The Owl Service",
                            Year = 1967,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22823,
                            Title = "Thursbitch",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27725,
                            Title = "Elidor",
                            Year = 1965,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5685,
                            Title = "The Weirdstone of Brisingamen",
                            Year = 1960,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5686,
                            Title = "The Moon of Gomrath",
                            Year = 1963,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5687,
                            Title = "Boneland",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1461,
                    Name = "Richard Jefferies",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3126,
                            Title = "After London:  or, Wild England",
                            Year = 1885,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1474,
                    Name = "Vladimir Nabokov",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3181,
                            Title = "Ada or Ardor: A Family Chronicle",
                            Year = 1969,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23371,
                            Title = "The Eye",
                            Year = 1965,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6646,
                            Title = "Pale Fire",
                            Year = 1962,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23370,
                            Title = "Invitation to a Beheading",
                            Year = 1959,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36080,
                            Title = "Bend Sinister",
                            Year = 1947,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1532,
                    Name = "Ari Marmell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3388,
                            Title = "The Goblin Corps",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4114,
                            Title = "The Conqueror's Shadow",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4115,
                            Title = "The Warlord's Legacy",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4907,
                            Title = "In Thunder Forged: Iron Kingdoms Chronicles",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20041,
                            Title = "Hot Lead, Cold Iron",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20042,
                            Title = "Hallow Point",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20043,
                            Title = "Dead to Rites",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3809,
                            Title = "Thief's Covenant",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3924,
                            Title = "False Covenant",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10911,
                            Title = "Lost Covenant",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10912,
                            Title = "Covenant's End",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1536,
                    Name = "Robin Wayne Bailey",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35433,
                            Title = "Little Green MenΓÇöAttack!",
                            Year = 2017,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18577,
                            Title = "The Children's Crusade",
                            Year = 2007,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16021,
                            Title = "Shadowdance",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32080,
                            Title = "Night Watch",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32077,
                            Title = "Frost",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32078,
                            Title = "Skull Gate",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32079,
                            Title = "Bloodsongs",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3409,
                            Title = "Swords Against the Shadowland",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11243,
                            Title = "The Lake of Fire",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1547,
                    Name = "Brenda Cooper",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22284,
                            Title = "Post",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28739,
                            Title = "Iron Pegasus",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4902,
                            Title = "Mayan December",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31938,
                            Title = "The Hebras and the Demons and the Damned",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23369,
                            Title = "My Father's Singularity",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32014,
                            Title = "In Their Garden",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8680,
                            Title = "Building Harlequin's Moon",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19873,
                            Title = "Savant Songs",
                            Year = 2004,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10913,
                            Title = "Edge of Dark",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18833,
                            Title = "Spear of Light",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22224,
                            Title = "Wilders",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28435,
                            Title = "Keepers",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4505,
                            Title = "The Creative Fire",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6156,
                            Title = "The Diamond Deep",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3479,
                            Title = "The Silver Ship and the Sea",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3480,
                            Title = "Reading the Wind",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3481,
                            Title = "Wings of Creation",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1555,
                    Name = "Nancy Holder",
                    Nominations = 3,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3497,
                            Title = "Dead in the Water",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 24177,
                            Title = "The Ghosts of Tivoli",
                            Year = 1992,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26085,
                            Title = "Making Love",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26086,
                            Title = "Witch-Light",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 27983,
                            Title = "Big Damn Hero",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16938,
                            Title = "Measure of a Man",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4130,
                            Title = "Possessions",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4131,
                            Title = "The Evil Within",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4132,
                            Title = "The Screaming Season",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1568,
                    Name = "Arthur Machen",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3514,
                            Title = "The Hill of Dreams",
                            Year = 1907,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 3515,
                            Title = "Tales of Horror and the Supernatural",
                            Year = 1948,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26778,
                            Title = "The Angel of Mons:  The Bowman and other Legends of the War",
                            Year = 1915,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12404,
                            Title = "The House of Souls",
                            Year = 1906,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 7513,
                            Title = "The Three Impostors",
                            Year = 1895,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1589,
                    Name = "Dante Alighieri",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3556,
                            Title = "Inferno",
                            Year = 1308,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3557,
                            Title = "Purgatorio",
                            Year = 1308,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3558,
                            Title = "Paradiso",
                            Year = 1308,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1610,
                    Name = "Jeremy C. Shipp",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3600,
                            Title = "Cursed",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 28041,
                            Title = "The Atrocities",
                            Year = 2018,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31394,
                            Title = "Bedfellow",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1635,
                    Name = "M. T. Anderson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3706,
                            Title = "Feed",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25108,
                            Title = "Landscape with Invisible Hand",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1644,
                    Name = "Brian Jacques",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 3744,
                            Title = "Redwall",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3745,
                            Title = "Mossflower",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3746,
                            Title = "Mattimeo",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3747,
                            Title = "Mariel of Redwall",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3748,
                            Title = "Salamandastron",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3749,
                            Title = "Martin the Warrior",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3750,
                            Title = "The Bellmaker",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3751,
                            Title = "Outcast of Redwall",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3752,
                            Title = "Pearls of Lutra",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3753,
                            Title = "The Long Patrol",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3754,
                            Title = "Marlfox",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3755,
                            Title = "The Legend of Luke",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3756,
                            Title = "Lord Brocktree",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3757,
                            Title = "Taggerung",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3758,
                            Title = "Triss",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3759,
                            Title = "Loamhedge",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3760,
                            Title = "Rakkety Tam",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3761,
                            Title = "High Rhulain",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3762,
                            Title = "Eulalia!",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3763,
                            Title = "Doomwyte",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3764,
                            Title = "The Sable Quean",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3765,
                            Title = "The Rogue Crew",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1652,
                    Name = "David Tallerman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16767,
                            Title = "Patchwerk",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22316,
                            Title = "Jenny's Sick",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 3831,
                            Title = "Giant Thief",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8583,
                            Title = "Crown Thief",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8584,
                            Title = "Prince Thief",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1668,
                    Name = "Rosemary Edghill",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9681,
                            Title = "Dead Reckoning",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 33866,
                            Title = "Murder by Magic: Twenty Tales of Crime and the Supernatural",
                            Year = 2004,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31891,
                            Title = "The Warslayer",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10156,
                            Title = "Beyond World's End",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10157,
                            Title = "Spirits White as Lightning",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10158,
                            Title = "Mad Maudlin",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10159,
                            Title = "Music to My Sorrow",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3917,
                            Title = "The Shadow of Albion",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 3918,
                            Title = "Leopard in Exile",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7009,
                            Title = "Legacies",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7010,
                            Title = "Conspiracies",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7011,
                            Title = "Sacrifices",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7012,
                            Title = "Victories",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1705,
                    Name = "Alexey Pehov",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4740,
                            Title = "Shadow Prowler",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4116,
                            Title = "Shadow Chaser",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4741,
                            Title = "Shadow Blizzard",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13188,
                            Title = "Chasers of the Wind",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1710,
                    Name = "Lee Thomas",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 6981,
                            Title = "Butcher's Road",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6982,
                            Title = "Like Light for Flies ",
                            Year = 2013,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4124,
                            Title = "The German",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6980,
                            Title = "The Dust of Wonderland ",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 6979,
                            Title = "Stained",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1738,
                    Name = "F. Marion Crawford",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4228,
                            Title = "Khaled",
                            Year = 1891,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10885,
                            Title = "The Witch of Prague and Other Stories",
                            Year = 1891,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1782,
                    Name = "Victor Pelevin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12096,
                            Title = "Hall of the Singing Caryatids",
                            Year = 2011,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 18594,
                            Title = "S.N.U.F.F.",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17542,
                            Title = "Empire V: The Prince of Hamlet",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7653,
                            Title = "The Sacred Book of the Werewolf",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16329,
                            Title = "Homo Zapiens",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16283,
                            Title = "Buddha's Little Finger",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16260,
                            Title = "The Life of Insects",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16302,
                            Title = "The Yellow Arrow",
                            Year = 1993,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4442,
                            Title = "Omon Ra",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16312,
                            Title = "The Blue Lantern:  And Other Stories",
                            Year = 1991,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9531,
                            Title = "The Helmet of Horror",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1796,
                    Name = "Eric Frank Russell",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8478,
                            Title = "Entities:  The Selected Novels of Eric Frank Russell",
                            Year = 2001,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8058,
                            Title = "Major Ingredients:  The Selected Short Stories of Eric Frank Russell",
                            Year = 2000,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11011,
                            Title = "Design for Great-Day",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10455,
                            Title = "Somewhere a Voice",
                            Year = 1965,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25616,
                            Title = "Far Stars",
                            Year = 1961,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 4492,
                            Title = "Wasp",
                            Year = 1958,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25615,
                            Title = "Legwork",
                            Year = 1956,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21613,
                            Title = "Allamagoosa",
                            Year = 1955,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8489,
                            Title = "Men, Martians and Machines",
                            Year = 1955,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14667,
                            Title = "Three to Conquer",
                            Year = 1955,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31662,
                            Title = "... And Then There Were None",
                            Year = 1951,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21358,
                            Title = "Sentinels from Space / The Ultimate Invader and Other Science-Fiction",
                            Year = 1954,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21361,
                            Title = "Three to Conquer / Doomsday Eve",
                            Year = 1957,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21580,
                            Title = "The Space Willies / Six Worlds Yonder",
                            Year = 1958,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18441,
                            Title = "The Best of Eric Frank Russell",
                            Year = 1978,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12925,
                            Title = "Sinister Barrier",
                            Year = 1939,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10723,
                            Title = "The Great Explosion",
                            Year = 1962,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8477,
                            Title = "Sentinels from Space",
                            Year = 1953,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 1823,
                    Name = "Sheri Holman",
                    Nominations = 1,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4574,
                            Title = "Witches on the Road Tonight",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1838,
                    Name = "Gavin J. Grant",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9608,
                            Title = "Monstrous Affections:  An Anthology of Beastly Tales",
                            Year = 2014,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 9609,
                            Title = "Steampunk! An Anthology of Fantastically Rich and Strange Stories",
                            Year = 2011,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28995,
                            Title = "Widows in the World",
                            Year = 2011,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16241,
                            Title = "The Best of Lady Churchill's Rosebud Wristlet",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4652,
                            Title = "The Year's Best Fantasy and Horror: Seventeenth Annual Collection",
                            Year = 2004,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4653,
                            Title = "The Year's Best Fantasy and Horror: Eighteenth Annual Collection",
                            Year = 2005,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4654,
                            Title = "The Year's Best Fantasy and Horror: Nineteenth Annual Collection",
                            Year = 2006,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4655,
                            Title = "The Year's Best Fantasy and Horror: Twentieth Annual Collection",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4656,
                            Title = "The Year's Best Fantasy and Horror: Twenty-First Annual Collection",
                            Year = 2008,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1845,
                    Name = "Chuck Hogan",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4707,
                            Title = "The Strain",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4708,
                            Title = "The Fall",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 4709,
                            Title = "The Night Eternal",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1878,
                    Name = "Tee Morris",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 4981,
                            Title = "Phoenix Rising",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4982,
                            Title = "The Janus Affair",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10807,
                            Title = "Dawn's Early Light",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10808,
                            Title = "The Diamond Conspiracy",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1879,
                    Name = "Diana L. Paxson",
                    Nominations = 3,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5281,
                            Title = "The White Raven",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6868,
                            Title = "The Serpent's Tooth",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6869,
                            Title = "The Paradise Tree",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6870,
                            Title = "White Mare, Red Stallion",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6871,
                            Title = "Brisingamen",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4984,
                            Title = "The Forest House",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4985,
                            Title = "Lady of Avalon",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4986,
                            Title = "Priestess of Avalon",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4987,
                            Title = "Ancestors of Avalon",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4988,
                            Title = "Ravens of Avalon",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 4989,
                            Title = "Sword of Avalon",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6897,
                            Title = "The Book of the Sword",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6898,
                            Title = "The Book of the Spear",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6899,
                            Title = "The Book of the Cauldron",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6900,
                            Title = "The Book of the Stone",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28602,
                            Title = "Marion Zimmer Bradley's Sword and Sorceress XXI",
                            Year = 2004,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5280,
                            Title = "Lady of Light",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6890,
                            Title = "Lady of Darkness",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6891,
                            Title = "Silverhair the Wanderer",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6892,
                            Title = "The Earthstone",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6893,
                            Title = "The Sea Star",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6894,
                            Title = "The Wind Crystal",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6895,
                            Title = "The Jewel of Fire",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6896,
                            Title = "The Golden Hills of Westria",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6872,
                            Title = "The Wolf and the Raven",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6873,
                            Title = "The Dragons of the Rhine",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6874,
                            Title = "The Lord of Horses",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1884,
                    Name = "Faith Hunter",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5047,
                            Title = "Skinwalker",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5048,
                            Title = "Blood Cross",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5049,
                            Title = "Mercy Blade",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5050,
                            Title = "Raven Cursed",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5051,
                            Title = "Death's Rival",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5052,
                            Title = "Blood Trade",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12645,
                            Title = "Black Arts",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12646,
                            Title = "Broken Soul",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12647,
                            Title = "Dark Heir",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19638,
                            Title = "Shadow Rites",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23648,
                            Title = "Cold Reign",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27326,
                            Title = "Dark Queen",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35459,
                            Title = "Shattered Bonds",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5044,
                            Title = "Bloodring",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5045,
                            Title = "Seraphs",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5046,
                            Title = "Host",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19639,
                            Title = "Blood of the Earth",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19640,
                            Title = "Curse on the Land",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25562,
                            Title = "Flame in the Dark",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32445,
                            Title = "Circle of the Moon",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1896,
                    Name = "L. L. Soares",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5091,
                            Title = "Life Rage",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1910,
                    Name = "Jenn Bennett",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5159,
                            Title = "Kindling the Moon",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5160,
                            Title = "Summoning the Night",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5161,
                            Title = "Binding the Shadows",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 1935,
                    Name = "Koji Suzuki",
                    Nominations = 1,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5335,
                            Title = "Edge: A Novel",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10289,
                            Title = "Dark Water",
                            Year = 1996,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 36097,
                            Title = "Floating Water",
                            Year = 1996,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10285,
                            Title = "Ring",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10286,
                            Title = "Spiral",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10287,
                            Title = "Loop",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 10288,
                            Title = "Birthday",
                            Year = 1999,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26686,
                            Title = "S: Es",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 1983,
                    Name = "Rod Rees",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 5563,
                            Title = "The Demi-Monde: Winter",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5564,
                            Title = "The Demi-Monde: Spring",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5565,
                            Title = "The Demi-Monde: Summer",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5566,
                            Title = "The Demi-Monde: Fall",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2039,
                    Name = "David Barnett",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16796,
                            Title = "The Golden Apple of Shangri-La",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16795,
                            Title = "Business as Usual",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16794,
                            Title = "Work Sets You Free",
                            Year = 2013,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5822,
                            Title = "Gideon Smith and the Mechanical Girl",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9544,
                            Title = "Gideon Smith and the Brass Dragon",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14681,
                            Title = "Gideon Smith and the Mask of the Ripper",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2046,
                    Name = "Kevin Brockmeier",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23225,
                            Title = "The Invention of Separate People",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6165,
                            Title = "The Illumination",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6163,
                            Title = "The View from the Seventh Layer",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5857,
                            Title = "The Brief History of the Dead",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17723,
                            Title = "The Brief History of the Dead",
                            Year = 2003,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6164,
                            Title = "The Truth About Celia",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6166,
                            Title = "Things That Fall from the Sky",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19906,
                            Title = "Real Unreal:  Best American Fantasy Volume III",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2050,
                    Name = "Steven Brust",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26984,
                            Title = "Good Guys",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16522,
                            Title = "The Desecrator",
                            Year = 2011,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5931,
                            Title = "Freedom & Necessity",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5930,
                            Title = "Agyar",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5929,
                            Title = "The Gypsy",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5928,
                            Title = "Cowboy Feng's Space Bar and Grille",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 5908,
                            Title = "Brokedown Palace",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14453,
                            Title = "To Reign in Hell",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17782,
                            Title = "When the Bow Breaks",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16895,
                            Title = "Fireworks in the Rain",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5932,
                            Title = "The Incrementalists",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19490,
                            Title = "The Skill of Our Hands",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5909,
                            Title = "The Phoenix Guards",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5910,
                            Title = "Five Hundred Years After",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5911,
                            Title = "The Paths of the Dead",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5912,
                            Title = "The Lord of Castle Black",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5913,
                            Title = "Sethra Lavode",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5927,
                            Title = "The Sun, the Moon, and the Stars",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5914,
                            Title = "Jhereg",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5915,
                            Title = "Yendi",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5916,
                            Title = "Teckla",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5917,
                            Title = "Taltos",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5918,
                            Title = "Phoenix",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5919,
                            Title = "Athyra",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5920,
                            Title = "Orca",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5921,
                            Title = "Dragon",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5922,
                            Title = "Issola",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5923,
                            Title = "Dzur",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5924,
                            Title = "Jhegaala",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5925,
                            Title = "Iorich",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 5926,
                            Title = "Tiassa",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 9519,
                            Title = "Hawk",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24816,
                            Title = "Vallista",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2066,
                    Name = "Michelle Hodkin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 6094,
                            Title = "The Unbecoming of Mara Dyer",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6095,
                            Title = "The Evolution of Mara Dyer",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6096,
                            Title = "The Retribution of Mara Dyer",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2077,
                    Name = "William King",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27754,
                            Title = "Visiting the Dead",
                            Year = 1989,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26776,
                            Title = "The Macharian Crusade",
                            Year = 2017,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26773,
                            Title = "Angel of Fire",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26774,
                            Title = "Fist of Demetrius",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26775,
                            Title = "Fall of Macharius",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26707,
                            Title = "Space Wolf: The Second Omnibus",
                            Year = 2009,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26706,
                            Title = "The Space Wolf Omnibus",
                            Year = 2007,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26698,
                            Title = "Space Wolf",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26699,
                            Title = "Ragnar's Claw",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26700,
                            Title = "Grey Hunter",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26701,
                            Title = "Wolfblade",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 6132,
                            Title = "Blood of Aenarion",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6133,
                            Title = "Sword of Caledor",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 6134,
                            Title = "Bane of Malekith",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15430,
                            Title = "Trollslayer",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15431,
                            Title = "Skavenslayer",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15432,
                            Title = "Daemonslayer",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15433,
                            Title = "Dragonslayer",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15434,
                            Title = "Beastslayer",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15435,
                            Title = "Vampireslayer",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15436,
                            Title = "Giantslayer",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2099,
                    Name = "Claire North",
                    Nominations = 6,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35017,
                            Title = "The Pursuit of William Abbey",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27901,
                            Title = "84K",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22380,
                            Title = "The End of the Day",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17474,
                            Title = "The Sudden Appearance of Hope",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11050,
                            Title = "Touch",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 7361,
                            Title = "The First Fifteen Lives of Harry August ",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 3,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16366,
                            Title = "The Serpent",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16367,
                            Title = "The Thief",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16368,
                            Title = "The Master",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2103,
                    Name = "Michael Rowe",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 7661,
                            Title = "Wild Fell",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 15330,
                            Title = "Enter, Night",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12205,
                            Title = "Sons of Darkness:  Tales of Men, Blood and Immortality",
                            Year = 1996,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12206,
                            Title = "Queer Fear:  Gay Horror Fiction",
                            Year = 2000,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12207,
                            Title = "Queer Fear II:  Gay Horror Fiction, Vol. 2",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2144,
                    Name = "Mick Farren",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 7891,
                            Title = "Mars - The Red Planet",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21857,
                            Title = "The DNA Cowboys Trilogy",
                            Year = 2002,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7886,
                            Title = "The Quest of the DNA Cowboys",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7887,
                            Title = "Synaptic Manhunt",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7888,
                            Title = "The Neural Atrocity",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7890,
                            Title = "The Last Stand of the DNA Cowboys",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 7885,
                            Title = "Road Movie",
                            Year = 2012,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2156,
                    Name = "Mark T. Barnes",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 7925,
                            Title = "The Garden of Stones",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7968,
                            Title = "The Obsidian Heart",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 7969,
                            Title = "The Pillars of Sand",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2168,
                    Name = "Lynda Barry",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 7967,
                            Title = "Cruddy:  An Illustrated Novel",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2176,
                    Name = "Lauren Oliver",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19825,
                            Title = "Replica",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14932,
                            Title = "Rooms",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 8068,
                            Title = "Delirium",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8067,
                            Title = "Pandemonium",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8065,
                            Title = "Requiem",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2207,
                    Name = "John Sunseri",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13339,
                            Title = "The Spiraling Worm:  Man vs. the Cthulhu Mythos",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 8241,
                            Title = "Cthulhu Unbound, Vol. 1",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 8242,
                            Title = "Cthulhu Unbound, Vol. 2 ",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2211,
                    Name = "David Lee Summers",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16758,
                            Title = "The Pirates of Sufiro",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16760,
                            Title = "Children of the Old Stars",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16761,
                            Title = "Heirs of the New Earth",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16762,
                            Title = "The Solar Sea",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8244,
                            Title = "Vampires of the Scarlet Order",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 8245,
                            Title = "Dragon's Fall: Rise of the Scarlet Order ",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2212,
                    Name = "Noemi Szecsi",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8246,
                            Title = "The Finno-Ugrian Vampire ",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2221,
                    Name = "Mark Adlard",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8281,
                            Title = "Interface",
                            Year = 1971,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8282,
                            Title = "Volteface",
                            Year = 1972,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8283,
                            Title = "Multiface",
                            Year = 1975,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2224,
                    Name = "Stella Duffy",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8290,
                            Title = "Singling Out the Couples ",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2230,
                    Name = "Betsy James",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24695,
                            Title = "Roadsouls",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24693,
                            Title = "Long Night Dance",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24694,
                            Title = "Dark Heart",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8298,
                            Title = "Listening at the Gate ",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2234,
                    Name = "Bennett Madison",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8315,
                            Title = "September Girls ",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2250,
                    Name = "Jillian Weise",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8335,
                            Title = "The Colony",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2279,
                    Name = "Donald A. Wollheim",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28965,
                            Title = "The Best from the Rest of the World",
                            Year = 1976,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28619,
                            Title = "More Macabre",
                            Year = 1961,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26736,
                            Title = "One Against the Moon",
                            Year = 1956,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35272,
                            Title = "Mimic",
                            Year = 1942,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 21358,
                            Title = "Sentinels from Space / The Ultimate Invader and Other Science-Fiction",
                            Year = 1954,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21359,
                            Title = "Adventures in the Far Future / Tales of Outer Space",
                            Year = 1954,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21396,
                            Title = "The Earth in Peril / Who Speaks of Conquest?",
                            Year = 1957,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21331,
                            Title = "Men on the Moon / City on the Moon",
                            Year = 1958,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10390,
                            Title = "The Secret of Saturn's Rings",
                            Year = 1954,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10405,
                            Title = "Secret of the Martian Moons",
                            Year = 1955,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10409,
                            Title = "The Secret of the Ninth Planet",
                            Year = 1959,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8602,
                            Title = "World's Best Science Fiction:  1965",
                            Year = 1965,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8603,
                            Title = "World's Best Science Fiction:  1966",
                            Year = 1966,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8604,
                            Title = "World's Best Science Fiction:  1967",
                            Year = 1967,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8605,
                            Title = "World's Best Science Fiction:  1968",
                            Year = 1968,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8599,
                            Title = "World's Best Science Fiction:  1969",
                            Year = 1969,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8606,
                            Title = "World's Best Science Fiction:  1970",
                            Year = 1970,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8607,
                            Title = "World's Best Science Fiction:  1971",
                            Year = 1971,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8638,
                            Title = "The 1972 Annual World's Best SF ",
                            Year = 1972,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8639,
                            Title = "The 1973 Annual World's Best SF",
                            Year = 1973,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8640,
                            Title = "The 1974 Annual World's Best SF",
                            Year = 1974,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8642,
                            Title = "The 1975 Annual World's Best SF",
                            Year = 1975,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8645,
                            Title = "The 1976 Annual World's Best SF",
                            Year = 1976,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8647,
                            Title = "The 1977 Annual World's Best SF",
                            Year = 1977,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8671,
                            Title = "The 1978 Annual World's Best SF",
                            Year = 1978,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8672,
                            Title = "The 1979 Annual World's Best SF",
                            Year = 1979,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8673,
                            Title = "The 1980 Annual World's Best SF",
                            Year = 1980,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8674,
                            Title = "The 1981 Annual World's Best SF",
                            Year = 1981,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8675,
                            Title = "The 1982 Annual World's Best SF",
                            Year = 1982,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8676,
                            Title = "The 1983 Annual World's Best SF",
                            Year = 1983,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8677,
                            Title = "The 1984 Annual World's Best SF",
                            Year = 1984,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8682,
                            Title = "The 1985 Annual World's Best SF",
                            Year = 1985,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8683,
                            Title = "The 1986 Annual World's Best SF",
                            Year = 1986,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8684,
                            Title = "The 1987 Annual World's Best SF",
                            Year = 1987,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8685,
                            Title = "The 1988 Annual World's Best SF",
                            Year = 1988,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8686,
                            Title = "The 1989 Annual World's Best SF",
                            Year = 1989,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8687,
                            Title = "The 1990 Annual World's Best SF",
                            Year = 1990,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2300,
                    Name = "Claude Askew",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8773,
                            Title = "Aylmer Vance:  Ghost-Seer",
                            Year = 1998,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2314,
                    Name = "Amelia B. Edwards",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8801,
                            Title = "All Saints' Eve",
                            Year = 2008,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2325,
                    Name = "Louisa Baldwin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8813,
                            Title = "The Shadow on the Blind and Other Stories",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2336,
                    Name = "James Mortimore",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8928,
                            Title = "Skaldenland",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15029,
                            Title = "Clark's Law",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8828,
                            Title = "Beltempest",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9183,
                            Title = "Lucifer Rising",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10217,
                            Title = "Blood Heat",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10245,
                            Title = "Parasite",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10305,
                            Title = "Eternity Weeps",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8922,
                            Title = "Eye of Heaven",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2340,
                    Name = "Jeremy Hoad",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8838,
                            Title = "The Blue Angel",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2363,
                    Name = "David Bishop",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19420,
                            Title = "On the Street of the Serpents",
                            Year = 1974,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22988,
                            Title = "Who Killed Kennedy",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8892,
                            Title = "The Domino Effect",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9087,
                            Title = "Amorality Tale",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9101,
                            Title = "Empire of Death",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15088,
                            Title = "A Massacre in Marienburg",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15082,
                            Title = "A Murder in Marienburg",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2379,
                    Name = "Hillary Jordan",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 8972,
                            Title = "When She Woke ",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2385,
                    Name = "Thomas Sweterlitsch",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27243,
                            Title = "The Gone World",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8993,
                            Title = "Tomorrow and Tomorrow",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2387,
                    Name = "Marcus Sakey",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24031,
                            Title = "Afterlife",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 8998,
                            Title = "Brilliance Saga",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 8999,
                            Title = "A Better World",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24030,
                            Title = "Written in Fire",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2394,
                    Name = "Peter Darvill-Evans",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9182,
                            Title = "Deceit",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9040,
                            Title = "Independence Day",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9055,
                            Title = "Asylum",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2417,
                    Name = "Porochista Khakpour",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9115,
                            Title = "The Last Illusion",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2471,
                    Name = "James P. Hogan",
                    Nominations = 7,
                    Wins = 2,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12845,
                            Title = "Migration",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12844,
                            Title = "Moon Flower",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12843,
                            Title = "Echoes of an Alien Sky",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12850,
                            Title = "Catastrophes, Chaos & Convolutions",
                            Year = 2005,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12841,
                            Title = "Martian Knightlife",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12840,
                            Title = "The Legend That Was Earth",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12849,
                            Title = "Rockets, Redheads & Revolution",
                            Year = 1999,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12839,
                            Title = "Star Child",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12838,
                            Title = "Bug Park",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11551,
                            Title = "Paths to Otherwhere",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12837,
                            Title = "Realtime Interrupt",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12851,
                            Title = "Out of Time",
                            Year = 1993,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11550,
                            Title = "The Multiplex Man",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11549,
                            Title = "The Infinity Gambit",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11548,
                            Title = "The Mirror Maze",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12848,
                            Title = "Minds, Machines and Evolution",
                            Year = 1988,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12836,
                            Title = "Endgame Enigma",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12835,
                            Title = "The Proteus Operation",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11547,
                            Title = "Voyage from Yesteryear",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12830,
                            Title = "Thrice Upon a Time",
                            Year = 1980,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12829,
                            Title = "The Two Faces of Tomorrow",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11546,
                            Title = "The Genesis Machine",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25152,
                            Title = "Code of the Lifemaker",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25153,
                            Title = "The Immortality Option",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11552,
                            Title = "Cradle of Saturn",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11553,
                            Title = "The Anguished Dawn",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12815,
                            Title = "Outward Bound",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9389,
                            Title = "The Minervan Experiment",
                            Year = 1981,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9390,
                            Title = "Inherit the Stars",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9391,
                            Title = "The Gentle Giants of Ganymede",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9392,
                            Title = "Giants' Star",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9393,
                            Title = "Entoverse",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 9394,
                            Title = "Mission to Minerva",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2545,
                    Name = "Ted Reynolds",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9799,
                            Title = "The Tides of God",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21423,
                            Title = "Can These Bones Live?",
                            Year = 1979,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20817,
                            Title = "Ker-Plop",
                            Year = 1979,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2553,
                    Name = "Loren J. MacGregor",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 9834,
                            Title = "The Net",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2590,
                    Name = "Reki Kawahara",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10844,
                            Title = "Accel World 1: Kuroyukihime's Return",
                            Year = 2009,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10845,
                            Title = "Accel World 2: The Red Storm Princess",
                            Year = 2009,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10846,
                            Title = "Accel World 3: The Twilight Marauder",
                            Year = 2009,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12551,
                            Title = "Accel World 4: Flight Towards a Blue Sky",
                            Year = 2010,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14317,
                            Title = "Accel World 5: The Floating Starlight Bridge",
                            Year = 2010,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17573,
                            Title = "Accel World 6: Shrine Maiden of the Sacred Fire",
                            Year = 2010,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19845,
                            Title = "Accel World 7:  Armor of Catastrophe",
                            Year = 2011,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21163,
                            Title = "Accel World 8: The Binary Stars of Destiny",
                            Year = 2011,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22286,
                            Title = "Accel World 9: The Seven-Thousand-Year Prayer",
                            Year = 2011,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23546,
                            Title = "Accel World 10: Elements",
                            Year = 2011,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25670,
                            Title = "Accel World 11: The Carbide Wolf",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 26117,
                            Title = "Accel World 12: The Red Crest",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28042,
                            Title = "Accel World 13: Signal Fire at the Water's Edge",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28224,
                            Title = "Accel World 14: Archangel of Savage Light",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28617,
                            Title = "Accel World 15: The End and the Beginning",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31423,
                            Title = "Accel World 16: Snow White's Slumber",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 33897,
                            Title = "Accel World 17: Cradle of Stars",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 33898,
                            Title = "Accel World 18: The Black Dual Swordsman",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34935,
                            Title = "Accel World 19: Pull of the Dark Nebula",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35270,
                            Title = "Accel World 20: The Rivalry of White and Black",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36300,
                            Title = "Accel World 21: The Snow Sprite",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11962,
                            Title = "The Biter",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16514,
                            Title = "The Igniter",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20469,
                            Title = "The Trancer",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28155,
                            Title = "The Stinger",
                            Year = 2017,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10048,
                            Title = "Sword Art Online 1: Aincrad",
                            Year = 2009,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10049,
                            Title = "Sword Art Online 2: Aincrad",
                            Year = 2009,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10050,
                            Title = "Sword Art Online 3: Fairy Dance",
                            Year = 2009,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11041,
                            Title = "Sword Art Online 4: Fairy Dance",
                            Year = 2010,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12554,
                            Title = "Sword Art Online 5: Phantom Bullet",
                            Year = 2010,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14918,
                            Title = "Sword Art Online 6: Phantom Bullet",
                            Year = 2010,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17571,
                            Title = "Sword Art Online 7: Mother's Rosary",
                            Year = 2011,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19584,
                            Title = "Sword Art Online 8:  Early and Late",
                            Year = 2011,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21170,
                            Title = "Sword Art Online 9: Alicization Beginning",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22289,
                            Title = "Sword Art Online 10: Alicization Running",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24428,
                            Title = "Sword Art Online 11: Alicization Turning",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26098,
                            Title = "Sword Art Online 12: Alicization Rising",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28023,
                            Title = "Sword Art Online 13: Alicization Dividing",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28304,
                            Title = "Sword Art Online 14: Alicization Uniting",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30341,
                            Title = "Sword Art Online 15: Alicization Invading",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 33861,
                            Title = "Sword Art Online 16: Alicization Exploding",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35068,
                            Title = "Sword Art Online 17: Alicization Awakening",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35542,
                            Title = "Sword Art Online 18: Alicization Lasting",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36226,
                            Title = "Sword Art Online 19: Moon Cradle",
                            Year = 2017,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28232,
                            Title = "Sword Art Online Alternative Gun Gale Online, Vol. 1:  Squad Jam",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28664,
                            Title = "Sword Art Online Alternative Gun Gale Online, Vol. 2:  Second Squad Jam: Start",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31611,
                            Title = "Sword Art Online Alternative Gun Gale Online, Vol. 3:  Second Squad Jam: Finish",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 33863,
                            Title = "Sword Art Online Alternative Gun Gale Online, Vol. 4:  3rd Squad Jam: Betrayers' Choice",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35541,
                            Title = "Sword Art Online Alternative Gun Gale Online, Vol. 5:  3rd Squad Jam: Betrayers' Choice: Finish",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 35950,
                            Title = "Sword Art Online Alternative Gun Gale Online, Vol. 6:  One Sumer Day",
                            Year = 2017,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11040,
                            Title = "Sword Art Online Progressive 01",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11306,
                            Title = "Sword Art Online Progressive 02",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14215,
                            Title = "Sword Art Online Progressive 03",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20162,
                            Title = "Sword Art Online Progressive 04",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30340,
                            Title = "Sword Art Online Progressive 05",
                            Year = 2018,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 33862,
                            Title = "Sword Art Online Progressive 06",
                            Year = 2018,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2642,
                    Name = "Evan Hunter",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10370,
                            Title = "Find the Feathered Serpent",
                            Year = 1952,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10379,
                            Title = "Danger: Dinosaurs!",
                            Year = 1953,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2644,
                    Name = "Bryce Walton",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11364,
                            Title = "Dark of the Moon and Other Stories",
                            Year = 2011,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 10375,
                            Title = "Sons of the Ocean Deeps",
                            Year = 1952,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2660,
                    Name = "Michael McCollum",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10462,
                            Title = "The Clouds of Saturn",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25353,
                            Title = "A Greater Infinity",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2664,
                    Name = "C. J. Cutcliffe Hyne",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10469,
                            Title = "The Lost Continent:  The Story of Atlantis",
                            Year = 1900,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2694,
                    Name = "Ludvig Holberg",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10597,
                            Title = "The Journey of Niels Klim to the World Underground",
                            Year = 1741,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2696,
                    Name = "Honore de Balzac",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10586,
                            Title = "The Centenarian: or, The Two Beringhelds",
                            Year = 1822,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2761,
                    Name = "Frigyes Karinthy",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 10849,
                            Title = "Voyage to Faremido and Capillaria",
                            Year = 1916,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2782,
                    Name = "Brett M. Rogers",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27607,
                            Title = "Classical Traditions in Modern Fantasy",
                            Year = 2017,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 10962,
                            Title = "Classical Traditions in Science Fiction",
                            Year = 2015,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2797,
                    Name = "I. O. Evans",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11007,
                            Title = "Science Fiction Through the Ages 1",
                            Year = 1966,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11008,
                            Title = "Science Fiction Through the Ages 2",
                            Year = 1966,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2803,
                    Name = "Genevieve Cogman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11024,
                            Title = "The Invisible Library",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16314,
                            Title = "The Masked City",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19226,
                            Title = "The Burning Page",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23124,
                            Title = "The Lost Plot",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28210,
                            Title = "The Mortal Word",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35148,
                            Title = "The Secret Chapter",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2815,
                    Name = "Andrew Liptak",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11018,
                            Title = "War Stories:  New Military Science Fiction",
                            Year = 2014,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2849,
                    Name = "Alethea Kontis",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11207,
                            Title = "Enchanted",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11208,
                            Title = "Hero",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11209,
                            Title = "Dearest",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2870,
                    Name = "Ingrid Law",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11250,
                            Title = "Savvy",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2905,
                    Name = "Jo Spurrier",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11405,
                            Title = "Winter Be My Shield",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11406,
                            Title = "Black Sun Light My Way",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11407,
                            Title = "North Star Guide Me Home",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2906,
                    Name = "Kate Forsyth",
                    Nominations = 3,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11408,
                            Title = "Bitter Greens",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11415,
                            Title = "The Tower of Ravens",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11416,
                            Title = "The Shining City",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11417,
                            Title = "The Heart of Stars",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11409,
                            Title = "Dragonclaw",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11410,
                            Title = "The Pool of Two Moons",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11411,
                            Title = "The Cursed Towers",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11412,
                            Title = "The Forbidden Land",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11413,
                            Title = "The Skull of the World",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11414,
                            Title = "The Fathomless Caves",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 2911,
                    Name = "Richard Adams Locke",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11444,
                            Title = "The Moon Hoax",
                            Year = 1835,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2915,
                    Name = "Van Tassel Sutphen",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11450,
                            Title = "The Doomsman",
                            Year = 1906,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2923,
                    Name = "C. I. Defontenay",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11476,
                            Title = "Star:  Psi Cassiopeia",
                            Year = 1854,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2938,
                    Name = "Victor Kelleher",
                    Nominations = 3,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11516,
                            Title = "Born of the Sea",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 11517,
                            Title = "Into The Dark",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 11518,
                            Title = "The Ivory Trail",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 2939,
                    Name = "Meagan Spooner",
                    Nominations = 4,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27023,
                            Title = "Hunted",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11519,
                            Title = "These Broken Stars",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11520,
                            Title = "This Shattered World",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 2,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11521,
                            Title = "Their Fractured Light",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27021,
                            Title = "Unearthed",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34050,
                            Title = "Undying",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2956,
                    Name = "Matthew J. Harrington",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27250,
                            Title = "The Goliath Stone",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14122,
                            Title = "Man-Kzin Wars XII",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11575,
                            Title = "Red Tide",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2978,
                    Name = "Charles A. Spano, Jr.",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11633,
                            Title = "Spock, Messiah!",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 2987,
                    Name = "Mel Odom",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16509,
                            Title = "Golem",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16510,
                            Title = "Mimic",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16511,
                            Title = "Rebel",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15589,
                            Title = "The Lost Library of Cormanthyr",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15547,
                            Title = "The Jewel of Turmish",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15679,
                            Title = "Rising Tide",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15680,
                            Title = "Under Fallen Stars",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15681,
                            Title = "The Sea Devil's Eye",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17019,
                            Title = "Wrath of the Blue Lady",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 11672,
                            Title = "Master Sergeant",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15939,
                            Title = "Guerilla",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 12497,
                            Title = "Stranded",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3000,
                    Name = "Captain Samuel Brunt",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11754,
                            Title = "A Voyage to Cacklogallinia",
                            Year = 1727,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3004,
                    Name = "Elbert Perce",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11758,
                            Title = "Gulliver Joi",
                            Year = 1851,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3013,
                    Name = "Otis Adelbert Kline",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11771,
                            Title = "Maza of the Moon",
                            Year = 1929,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13886,
                            Title = "The Swordsman of Mars",
                            Year = 1960,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13887,
                            Title = "The Outlaws of Mars",
                            Year = 1961,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3019,
                    Name = "Hoa Pham",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11779,
                            Title = "Vixen",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3087,
                    Name = "Greig Beck",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 11919,
                            Title = "The First Bird",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 11920,
                            Title = "Book of the Dead",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3092,
                    Name = "Yuu Kamiya",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25672,
                            Title = "Clockwork Planet, Vol. 1",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28156,
                            Title = "Clockwork Planet, Vol. 2",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 31599,
                            Title = "Clockwork Planet, Vol. 3",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 33927,
                            Title = "Clockwork Planet, Vol. 4",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 11958,
                            Title = "No Game No Life, Vol. 1",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 12553,
                            Title = "No Game No Life, Vol. 2",
                            Year = 2012,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14216,
                            Title = "No Game No Life, Vol. 3",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17116,
                            Title = "No Game No Life, Vol. 4",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21570,
                            Title = "No Game No Life, Vol. 5",
                            Year = 2013,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24199,
                            Title = "No Game No Life, Vol. 6",
                            Year = 2014,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26680,
                            Title = "No Game No Life, Vol. 7",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 33926,
                            Title = "No Game No Life, Vol. 8",
                            Year = 2015,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35065,
                            Title = "No Game No Life, Vol. 9",
                            Year = 2016,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35946,
                            Title = "No Game No Life, Vol. 10",
                            Year = 2018,
                            Type = BookType.LightNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3161,
                    Name = "Susan Hill",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34928,
                            Title = "Dolly: A Ghost Story",
                            Year = 2012,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 27627,
                            Title = "The Small Hand: A Ghost Story",
                            Year = 2010,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12221,
                            Title = "The Man in the Picture:  A Ghost Story",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 27626,
                            Title = "The Mist in the Mirror",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 12220,
                            Title = "The Woman In Black:  A Ghost Story",
                            Year = 1983,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3183,
                    Name = "Lea Daley",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12262,
                            Title = "Futuredyke",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3188,
                    Name = "Hayford Peirce",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12267,
                            Title = "Phylum Monsters",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3240,
                    Name = "A. E. Silas",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12428,
                            Title = "The Panorama Egg",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3290,
                    Name = "Walter Besant",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 12855,
                            Title = "The Inner House",
                            Year = 1888,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3324,
                    Name = "Arsen Darnay",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13047,
                            Title = "The Purgatory Zone",
                            Year = 1981,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13048,
                            Title = "The Splendid Freedom",
                            Year = 1980,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13046,
                            Title = "Karma (The Karma Affair)",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13045,
                            Title = "The Siege of Faltara",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13044,
                            Title = "A Hostage for Hinterland",
                            Year = 1976,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3348,
                    Name = "Bill Pogue",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13153,
                            Title = "The Trikon Deception",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3356,
                    Name = "Patricia Matthews",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13272,
                            Title = "On Wings of Magic",
                            Year = 1994,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3366,
                    Name = "Daniel Harms",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13362,
                            Title = "Encyclopedia Cthulhiana, 2nd Edition:  A Guide to Lovecraftian Horror",
                            Year = 1998,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3400,
                    Name = "Robert Brockway",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13609,
                            Title = "The Unnoticeables:  A Novel",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 21778,
                            Title = "The Empty Ones:  A Novel",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 26564,
                            Title = "Kill All Angels",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3406,
                    Name = "Elizabeth Marshall Thomas",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 13679,
                            Title = "The Animal Wife",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 13678,
                            Title = "Reindeer Moon",
                            Year = 1987,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3456,
                    Name = "Christopher Palmer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17257,
                            Title = "Castaway Tales:  From Robinson Crusoe to Life of Pi",
                            Year = 2016,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 13923,
                            Title = "Philip K Dick:  Exhilaration and Terror of the Postmodern",
                            Year = 2003,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3487,
                    Name = "J. P. Telotte",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14006,
                            Title = "Science Fiction Double Feature:  The Science Fiction Film as Cult Text",
                            Year = 2015,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3507,
                    Name = "Justin Brooks",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14146,
                            Title = "Stephen King:  The Non-Fiction",
                            Year = 2009,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 14148,
                            Title = "Stephen King:  A Primary Bibliography, 2013 Revised Edition",
                            Year = 2008,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3514,
                    Name = "Eric S. Rabkin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21120,
                            Title = "Fantastic Worlds: Myths, Tales, and Stories",
                            Year = 1979,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 14182,
                            Title = "Arthur C. Clarke",
                            Year = 1979,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3533,
                    Name = "Lynne Truss",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14282,
                            Title = "Cat Out of Hell",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3536,
                    Name = "Peter Stenson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14297,
                            Title = "Fiend",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3556,
                    Name = "Kat Richardson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25722,
                            Title = "Indigo:  A Novel",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14441,
                            Title = "Greywalker",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14442,
                            Title = "Poltergeist",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14443,
                            Title = "Underground",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14444,
                            Title = "Vanished",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14445,
                            Title = "Labyrinth",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14446,
                            Title = "Downpour",
                            Year = 2011,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14447,
                            Title = "Seawitch",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14448,
                            Title = "Possession",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14449,
                            Title = "Revenant",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3559,
                    Name = "Laura Bickle",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14456,
                            Title = "Embers",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14459,
                            Title = "Sparks",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14464,
                            Title = "The Hallowed Ones",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 14465,
                            Title = "The Outside",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 14467,
                            Title = "Dark Alchemy",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14468,
                            Title = "Mercury Retrograde",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20507,
                            Title = "Nine of Stars",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27373,
                            Title = "Witch Creek",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32375,
                            Title = "Phoenix Falling",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3614,
                    Name = "Nancy Varian Berberick",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14861,
                            Title = "Tears of the Night Sky",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14803,
                            Title = "Dalamar the Dark",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14804,
                            Title = "The Inheritance",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14737,
                            Title = "Stormblade",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14805,
                            Title = "The Lioness",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14806,
                            Title = "Prisoner of Haven",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31930,
                            Title = "The Jewels of Elvish",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31931,
                            Title = "A Child of Elvish",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31932,
                            Title = "Shadow of the Seventh Moon",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31933,
                            Title = "The Panther's Hoard",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3623,
                    Name = "Jeff Crook",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14849,
                            Title = "The Rose and the Skull",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14891,
                            Title = "The Thieves' Guild",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14851,
                            Title = "Conundrum",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14853,
                            Title = "Dark Thane",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3627,
                    Name = "Linda P. Baker",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 14861,
                            Title = "Tears of the Night Sky",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 14862,
                            Title = "The Irda: Children of the Stars",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3677,
                    Name = "Justin Hunter",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15072,
                            Title = "Forged in Battle",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3692,
                    Name = "Alex Davis",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15134,
                            Title = "Death & Dishonour",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3693,
                    Name = "Antonia Honeywell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15137,
                            Title = "The Ship",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3715,
                    Name = "Diane Dillon",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15267,
                            Title = "The Sorcerer's Apprentice",
                            Year = 1993,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15266,
                            Title = "The Art of Leo & Diane Dillon",
                            Year = 1981,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3735,
                    Name = "Mark L. Van Name",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15378,
                            Title = "Onward, Drake!",
                            Year = 2015,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18641,
                            Title = "Intersections:  The Sycamore Hill Anthology",
                            Year = 1996,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27683,
                            Title = "Desert Rain",
                            Year = 1991,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15373,
                            Title = "One Jump Ahead",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15374,
                            Title = "Slanted Jack",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15375,
                            Title = "Overthrowing Heaven",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15376,
                            Title = "Children No More",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15377,
                            Title = "No Going Back",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3738,
                    Name = "Elaine Cunningham",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15410,
                            Title = "Evermeet: Island of Elves",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15394,
                            Title = "The Magehound",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15395,
                            Title = "The Floodgate",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15396,
                            Title = "The Wizardwar",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15391,
                            Title = "Daughter of the Drow",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15392,
                            Title = "Tangled Webs",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15393,
                            Title = "Windwalker",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15548,
                            Title = "The City of Splendors",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15963,
                            Title = "Dark Journey",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3751,
                    Name = "William Latham",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15531,
                            Title = "Shepherd Moon",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15520,
                            Title = "Resurrection",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15523,
                            Title = "Eternity Unbound",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15525,
                            Title = "Omega",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15526,
                            Title = "Alpha",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15528,
                            Title = "Johnny Byrne's Children of the Gods",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15530,
                            Title = "The Final Revolution",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3766,
                    Name = "Jason Mott",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15585,
                            Title = "The Wonder of All Things",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 15584,
                            Title = "The Returned",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3778,
                    Name = "Allen Wold",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15646,
                            Title = "V: The Pursuit of Diana",
                            Year = 1984,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15651,
                            Title = "V: The Crivit Experiment",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15662,
                            Title = "V: Below the Threshold",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3803,
                    Name = "Joseph Lidster",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15728,
                            Title = "Consequences",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3830,
                    Name = "Cathy Fenner",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15844,
                            Title = "Women of Wonder:  Celebrating Women Creators of Fantastic Art",
                            Year = 2015,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3863,
                    Name = "Greg Cox",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21099,
                            Title = "Captain to Captain",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20496,
                            Title = "Glass Empires",
                            Year = 2007,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19829,
                            Title = "Devil in the Sky",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19833,
                            Title = "Dragon's Honor",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19974,
                            Title = "The Q Continuum: Q-Space",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19975,
                            Title = "The Q Continuum: Q-Zone",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 19976,
                            Title = "The Q Continuum: Q-Strike",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32474,
                            Title = "The Antares Maelstrom",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 15980,
                            Title = "Child of Two Worlds",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20125,
                            Title = "Foul Deeds Will Rise",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20126,
                            Title = "No Time Like the Past",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20106,
                            Title = "The Weight of Worlds",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20328,
                            Title = "The Rings of Time",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20003,
                            Title = "Assignment: Eternity",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20103,
                            Title = "The Rise and Fall of Khan Noonien Singh, Volume One",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20104,
                            Title = "The Rise and Fall of Khan Noonien Singh, Volume Two",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20105,
                            Title = "To Reign in Hell: The Exile of Khan Noonien Sing",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20007,
                            Title = "The Black Shore",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25840,
                            Title = "War for the Planet of the Apes",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3867,
                    Name = "Isabella Carter",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15999,
                            Title = "Dragon Slayer",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3875,
                    Name = "Okasha SkatΓÇÖsi",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16023,
                            Title = "The Growing",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3896,
                    Name = "Pamela Mordecai",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16185,
                            Title = "Once on the Shores of the Stream Senegambia ",
                            Year = 2000,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 3909,
                    Name = "Jean Ray",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16236,
                            Title = "Malpertuis",
                            Year = 1943,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3916,
                    Name = "Janelle Mon├íe",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34010,
                            Title = "Dirty Computer",
                            Year = 2018,
                            Type = BookType.Miscellaneous,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16251,
                            Title = "The Electric Lady",
                            Year = 2013,
                            Type = BookType.Miscellaneous,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3952,
                    Name = "Kelly Robson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28486,
                            Title = "What Gentle Women Dare",
                            Year = 2018,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 21944,
                            Title = "A Human Stain",
                            Year = 2017,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 17979,
                            Title = "The Three Resurrections of Jessica Churchill",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28745,
                            Title = "Two-Year Man",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16365,
                            Title = "Waters of Versailles",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26985,
                            Title = "Gods, Monsters, and the Lucky Peach",
                            Year = 2018,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34417,
                            Title = "Intervention",
                            Year = 2018,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27359,
                            Title = "We Who Live in the Heart",
                            Year = 2017,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 3959,
                    Name = "Stefan Grabinski",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16385,
                            Title = "The Dark Domain",
                            Year = 1993,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 3976,
                    Name = "John Robert Colombo",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16427,
                            Title = "Windigo:  An Anthology of Fact and Fantastic Fiction",
                            Year = 1982,
                            Type = BookType.Anthology,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16428,
                            Title = "Friendly Aliens:  Thirteen Stories of the Fantastic Set in Canada",
                            Year = 1981,
                            Type = BookType.Anthology,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4004,
                    Name = "Sally Malcolm",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16602,
                            Title = "Rising",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16603,
                            Title = "A Matter of Honor",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16604,
                            Title = "The Cost of Honor",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16605,
                            Title = "Hostile Ground",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20463,
                            Title = "Exile",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4067,
                    Name = "D. B. Jackson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30087,
                            Title = "Time's Children",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30088,
                            Title = "Time's Demon",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16965,
                            Title = "The Price of Doing Business",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16972,
                            Title = "A Spell of Vengeance",
                            Year = 2012,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16966,
                            Title = "Thieftaker",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16968,
                            Title = "Thieves' Quarry",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16969,
                            Title = "A Plunder of Souls",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16971,
                            Title = "Dead Man's Reach",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4071,
                    Name = "David M. Henley",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 16980,
                            Title = "The Hunt for Pierre Jnr",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 16981,
                            Title = "Manifestations",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17011,
                            Title = "Convergence",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4072,
                    Name = "Nino Cipri",
                    Nominations = 2,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35829,
                            Title = "Finna",
                            Year = 2020,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22938,
                            Title = "Opals and Clay",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 16985,
                            Title = "The Shape of My Name",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4129,
                    Name = "Julio Cort├ízar",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25678,
                            Title = "62: A Model Kit",
                            Year = 1968,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32855,
                            Title = "Blow-Up and Other Stories",
                            Year = 1967,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32853,
                            Title = "Hopscotch",
                            Year = 1963,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17234,
                            Title = "Headache",
                            Year = 1951,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4131,
                    Name = "Greg Rucka",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17237,
                            Title = "Before the Awakening",
                            Year = 2015,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17236,
                            Title = "Smuggler's Run",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4136,
                    Name = "Norton Juster",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17246,
                            Title = "The Phantom Tollbooth",
                            Year = 1961,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4148,
                    Name = "Eric Walters",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17263,
                            Title = "Nothing to Fear",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4153,
                    Name = "Andy Marino",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17268,
                            Title = "The Oregon Trail Diary of Willa Porter",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4162,
                    Name = "J. T. Petty",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17282,
                            Title = "Angel Season",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22587,
                            Title = "Family Teeth (Part 5): American Jackal",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4177,
                    Name = "Abbey Mei Otis",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 29081,
                            Title = "Alien Virus Love Disaster",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17312,
                            Title = "Sweetheart",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4187,
                    Name = "Stephanie Bedwell-Grime",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17341,
                            Title = "Guardian Angel",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17342,
                            Title = "Fallen Angel",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4194,
                    Name = "C.S.E. Cooney",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34173,
                            Title = "Desdemona and the Deep",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25473,
                            Title = "Though She Be But Little",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17363,
                            Title = "The Bone Swans of Amandale",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17539,
                            Title = "Bone Swans:  Stories",
                            Year = 2015,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 29084,
                            Title = "Martyr's Gem",
                            Year = 2013,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 29015,
                            Title = "The Last Sophia",
                            Year = 2011,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28962,
                            Title = "Braiding the Ghosts",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17541,
                            Title = "Three Fancies from the Infernal Garden",
                            Year = 2009,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17540,
                            Title = "Stone Shoes",
                            Year = 2007,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30149,
                            Title = "The Breaker Queen",
                            Year = 2014,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30151,
                            Title = "The Two Paupers",
                            Year = 2015,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30130,
                            Title = "Witch, Beast, Saint: an Erotic Fairy Tale",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4205,
                    Name = "Ellen Glasgow",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17392,
                            Title = "The Shadowy Third and Other Stories",
                            Year = 1923,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 17393,
                            Title = "The Shadowy Third",
                            Year = 1916,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4224,
                    Name = "A. Igoni Barrett",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17440,
                            Title = "Blackass",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4226,
                    Name = "Sara Taylor",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17442,
                            Title = "The Shore",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4243,
                    Name = "Alain Mabanckou",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17511,
                            Title = "Memoirs of a Porcupine",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4274,
                    Name = "Anthony Earnshaw",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17767,
                            Title = "Musrum",
                            Year = 1968,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4275,
                    Name = "K. D. Wentworth",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 17771,
                            Title = "Kaleidoscope",
                            Year = 2007,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17768,
                            Title = "Born-Again",
                            Year = 2005,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17769,
                            Title = "Tall One",
                            Year = 1998,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17770,
                            Title = "Burning Bright",
                            Year = 1996,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17778,
                            Title = "The Imperium Game",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17776,
                            Title = "Black on Black",
                            Year = 1999,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17777,
                            Title = "Stars Over Stars",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17772,
                            Title = "Moonspeaker",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17773,
                            Title = "House of Moons",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17774,
                            Title = "The Course of Empire",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 17775,
                            Title = "The Crucible of Empire",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24871,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXV",
                            Year = 2009,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24872,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXVI",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24873,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXVII",
                            Year = 2011,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24874,
                            Title = "L. Ron Hubbard Presents Writers of the Future, Volume XXVIII",
                            Year = 2012,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4339,
                    Name = "Kent Brewster",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18408,
                            Title = "In the Pound, Near Breaktime",
                            Year = 1995,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4383,
                    Name = "Sylvain Neuvel",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31735,
                            Title = "The Test",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 18631,
                            Title = "Sleeping Giants",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21347,
                            Title = "Waking Gods",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27327,
                            Title = "Only Human",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4407,
                    Name = "Kevin Dockery",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18799,
                            Title = "Task Force Mars",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 18800,
                            Title = "Operation Orion",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4429,
                    Name = "Curtis C. Chen",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 18979,
                            Title = "Waypoint Kangaroo",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23875,
                            Title = "Kangaroo Too",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4447,
                    Name = "Anna Smaill",
                    Nominations = 1,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19122,
                            Title = "The Chimes",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4454,
                    Name = "J. W. Schutz",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19148,
                            Title = "Maiden Voyage",
                            Year = 1965,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4473,
                    Name = "David Goldblatt",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 19230,
                            Title = "The Time Traveler's Handbook:  18 Experiences from the Eruption of Vesuvius to Woodstock",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4552,
                    Name = "Jacob Weisman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32442,
                            Title = "The Unicorn Anthology",
                            Year = 2019,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 24140,
                            Title = "The New Voices of Fantasy",
                            Year = 2017,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 19966,
                            Title = "Invaders:  22 Tales from the Outer Limits of Literature",
                            Year = 2016,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 23766,
                            Title = "The Sword & Sorcery Anthology",
                            Year = 2012,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4559,
                    Name = "Suzanne Palmer",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36101,
                            Title = "Waterlines",
                            Year = 2019,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34121,
                            Title = "Thirty-Three Percent Joe",
                            Year = 2018,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27911,
                            Title = "Number Thirty-Nine Skink",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27356,
                            Title = "The Secret Life of Bots",
                            Year = 2017,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 30154,
                            Title = "Lazy Dog Out",
                            Year = 2016,
                            Type = BookType.Novella,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28759,
                            Title = "Ten Poems for the Mossums, One for the Man",
                            Year = 2016,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20127,
                            Title = "Shatterdown",
                            Year = 2014,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 32594,
                            Title = "Finder",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36069,
                            Title = "Driving the Deep",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4568,
                    Name = "John G. McDaid",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20138,
                            Title = "Keyboard Practice, Consisting of an Aria with Diverse Variations for the Harpsichord with two manuals",
                            Year = 2005,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20144,
                            Title = "Jigoku No Mokushiroku",
                            Year = 1995,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4590,
                    Name = "Simon Strantzas",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20208,
                            Title = "Aickman's Heirs",
                            Year = 2015,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 20207,
                            Title = "Year's Best Weird Fiction, Volume Three",
                            Year = 2016,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4591,
                    Name = "Alexander Weinstein",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20237,
                            Title = "Children of the New World",
                            Year = 2016,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28806,
                            Title = "Openness",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4596,
                    Name = "McCormick Templeman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20269,
                            Title = "The Glass Casket",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4621,
                    Name = "Eldon Thompson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20524,
                            Title = "The Crimson Sword",
                            Year = 2005,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20525,
                            Title = "The Obsidian Key",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20526,
                            Title = "The Divine Talisman",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4639,
                    Name = "Traci Chee",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20601,
                            Title = "The Reader",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31658,
                            Title = "The Speaker",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31659,
                            Title = "The Storyteller",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4643,
                    Name = "David Weddle",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20656,
                            Title = "Abyss",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4658,
                    Name = "Laurence Yep",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20723,
                            Title = "Shadow Lord",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4661,
                    Name = "Mark Garland",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35943,
                            Title = "Sword of the Prophets",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35944,
                            Title = "Dorella",
                            Year = 1992,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34077,
                            Title = "Demon Balde",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34078,
                            Title = "Frost",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20729,
                            Title = "Trial by Error",
                            Year = 1997,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20730,
                            Title = "Ghost of a Chance",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4665,
                    Name = "J. G. Hertzler",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20749,
                            Title = "The Left Hand of Destiny: Book One",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20750,
                            Title = "The Left Hand of Destiny: Book Two",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4667,
                    Name = "Dave Stern",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20752,
                            Title = "What Price Honor?",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20753,
                            Title = "Daedalus",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20754,
                            Title = "Daedalus's Children",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20755,
                            Title = "Rosetta",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20756,
                            Title = "The Children of Kings",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4669,
                    Name = "Jeri Taylor",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20769,
                            Title = "Unification",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20771,
                            Title = "Pathways",
                            Year = 1998,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 20770,
                            Title = "Mosaic",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4710,
                    Name = "Kathleen Tierney",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 20973,
                            Title = "Blood Oranges",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20974,
                            Title = "Red Delicious",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 20975,
                            Title = "Cherry Bomb",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4730,
                    Name = "John J. Ordover",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21701,
                            Title = "Star Trek: The Amazing Stories",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21055,
                            Title = "Wounds",
                            Year = 2008,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21126,
                            Title = "Strange New Worlds I",
                            Year = 1998,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21127,
                            Title = "Strange New Worlds II",
                            Year = 1999,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21128,
                            Title = "Strange New Worlds III",
                            Year = 2000,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21129,
                            Title = "Strange New Worlds IV",
                            Year = 2001,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21130,
                            Title = "Strange New Worlds V",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21131,
                            Title = "Strange New Worlds VI",
                            Year = 2003,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 21132,
                            Title = "Strange New Worlds VII",
                            Year = 2004,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4734,
                    Name = "Cory Rushton",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21055,
                            Title = "Wounds",
                            Year = 2008,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4736,
                    Name = "Robert T. Jeschonek",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21078,
                            Title = "Out of the Cocoon",
                            Year = 2010,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4758,
                    Name = "Shane Tourtellotte",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21246,
                            Title = "The Return of Spring",
                            Year = 2001,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4792,
                    Name = "Mark R. Hillegas",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21610,
                            Title = "The Future as Nightmare:  H. G. Wells and the Anti-Utopians",
                            Year = 1967,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4824,
                    Name = "J. Patrick Black",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21675,
                            Title = "Ninth City Burning",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4851,
                    Name = "Rhoda Nunes",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21864,
                            Title = "Recoil / Lallia",
                            Year = 1971,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4871,
                    Name = "Lidia Yuknavitch",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21955,
                            Title = "The Book of Joan:  A Novel",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4876,
                    Name = "Hirotaka Tobi",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 21994,
                            Title = "Saisensu Fikushon 2016",
                            Year = 2016,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28386,
                            Title = "The Thousand Year Beach",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4920,
                    Name = "Patrick Weekes",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22160,
                            Title = "The Palace Job",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22161,
                            Title = "The Prophecy Con",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22162,
                            Title = "The Paladin Caper",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4942,
                    Name = "Archie Roy",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22274,
                            Title = "Devil in the Darkness",
                            Year = 1978,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4950,
                    Name = "Giorgio De Maria",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22301,
                            Title = "The Twenty Days of Turin",
                            Year = 1977,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 4965,
                    Name = "Mitchell J. Freedman",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22349,
                            Title = "A Disturbance of Fate",
                            Year = 2003,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4975,
                    Name = "Julie Mayhew",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22378,
                            Title = "The Big Lie",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 4981,
                    Name = "Kathryn Hume",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22402,
                            Title = "Fantasy and Mimesis: Responses to Reality in Western Literature",
                            Year = 1984,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 4993,
                    Name = "Megan Arkenberg",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23219,
                            Title = "All in a Hot and Copper Sky",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22661,
                            Title = "The Huntsman",
                            Year = 2013,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 22441,
                            Title = "How Many Miles to Babylon?",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 22564,
                            Title = "The Suicide's Guide to the Absinthe of Perdition",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25503,
                            Title = "All the King's Monsters",
                            Year = 2010,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5093,
                    Name = "John Kinnaird",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22852,
                            Title = "Olaf Stapledon",
                            Year = 1986,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5105,
                    Name = "Kathleen Spencer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22899,
                            Title = "Charles Williams",
                            Year = 1987,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5134,
                    Name = "Joseph Helmreich",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 22995,
                            Title = "The Return",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5138,
                    Name = "Steve Hockensmith",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23014,
                            Title = "The Herd",
                            Year = 2014,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5157,
                    Name = "Chesya Burke",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23114,
                            Title = "Hidden Youth:  Speculative Fiction from the Margins of History",
                            Year = 2016,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5159,
                    Name = "Andr├⌐ M. Carrington",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23115,
                            Title = "Speculative Blackness: The Future of Race in Science Fiction",
                            Year = 2016,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5200,
                    Name = "Tora Greve",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23301,
                            Title = "The Philosopher's Stone",
                            Year = 2015,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5209,
                    Name = "Tristina Wright",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23339,
                            Title = "The Siren Son",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5226,
                    Name = "Greg Kurzawa",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23424,
                            Title = "Soccer Fields and Frozen Lakes",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5236,
                    Name = "Nigel Quinlan",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23514,
                            Title = "The Maloneys' Magical Weatherbox",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5243,
                    Name = "Paul Kincaid",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24230,
                            Title = "What It Is We Do When We Read Science Fiction",
                            Year = 2008,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 23646,
                            Title = "Iain M. Banks",
                            Year = 2017,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5254,
                    Name = "Eleanor Wasserberg",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23678,
                            Title = "Foxlowe",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5262,
                    Name = "Dan Moren",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 23709,
                            Title = "The Caledonian Gambit",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34383,
                            Title = "The Bayern Agenda",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36452,
                            Title = "The Aleph Extraction",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5272,
                    Name = "Maggy Thomas",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 479,
                            Title = "Broken Time",
                            Year = 2000,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5310,
                    Name = "Jennifer Donnelly",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24196,
                            Title = "Beauty and the Beast: Lost in a Book",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5346,
                    Name = "Joanne Hall",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24543,
                            Title = "The Summer Goddess",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5363,
                    Name = "Al Robertson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24769,
                            Title = "Crashing Heaven",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24770,
                            Title = "Waking Hell",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5406,
                    Name = "Darick Robertson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 24937,
                            Title = "Transmetropolitan, Vol. 1: Back on the Street",
                            Year = 1997,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24945,
                            Title = "Transmetropolitan, Vol. 2: Lust For Life",
                            Year = 2009,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24946,
                            Title = "Transmetropolitan, Vol. 3: Year of the Bastard",
                            Year = 2012,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24947,
                            Title = "Transmetropolitan, Vol. 4: The New Scum",
                            Year = 2012,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24948,
                            Title = "Transmetropolitan, Vol. 5: Lonely City",
                            Year = 2013,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24949,
                            Title = "Transmetropolitan, Vol. 6: Gouge Away",
                            Year = 2013,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24950,
                            Title = "Transmetropolitan, Vol. 7: Spider's Thrash",
                            Year = 2013,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24951,
                            Title = "Transmetropolitan, Vol. 8: Dirge",
                            Year = 2014,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24952,
                            Title = "Transmetropolitan, Vol. 9: The Cure",
                            Year = 2014,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 24953,
                            Title = "Transmetropolitan, Vol. 10: One More Time",
                            Year = 2011,
                            Type = BookType.GraphicNovel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5418,
                    Name = "Chinelo Onwualu",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25060,
                            Title = "Read Before Use",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5472,
                    Name = "Carl Neville",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25359,
                            Title = "Resolution Way",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5473,
                    Name = "Scott B. Smith",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25360,
                            Title = "The Ruins",
                            Year = 2006,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5504,
                    Name = "Ausma Zehanat Khan",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25601,
                            Title = "The Bloodprint",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30215,
                            Title = "The Black Khan",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5521,
                    Name = "Andrew Caldecott",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25723,
                            Title = "Rotherweird",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 27564,
                            Title = "Wyntertide",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5544,
                    Name = "Gwendolyn Clare",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28855,
                            Title = "Tasting Notes on the Varietals of the Southern Coast",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26124,
                            Title = "All the Painted Stars",
                            Year = 2012,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 25948,
                            Title = "Perfect Lies",
                            Year = 2011,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 28028,
                            Title = "Ink, Iron, and Glass",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32309,
                            Title = "Mist, Metal, and Ash",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5549,
                    Name = "Ayize Jama-Everett",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 25991,
                            Title = "The Liminal War",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25990,
                            Title = "The Liminal People",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 25992,
                            Title = "The Entropy of Bones",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5614,
                    Name = "Mervyn Wall",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26662,
                            Title = "The Unfortunate Fursey",
                            Year = 1947,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 26663,
                            Title = "The Return of Fursey",
                            Year = 1948,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5616,
                    Name = "Nat Cassidy",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26675,
                            Title = "Steal the Stars",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5645,
                    Name = "Liz Bourke",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 26911,
                            Title = "Sleeping with Monsters:  Readings and Reactions in Science Fiction and Fantasy",
                            Year = 2017,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5659,
                    Name = "Jos├⌐ Pablo Iriarte",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27100,
                            Title = "The Substance of My Lives, the Accidents of Our Births",
                            Year = 2018,
                            Type = BookType.Novelette,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5681,
                    Name = "Mira Bartok",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27264,
                            Title = "The Wonderling",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5690,
                    Name = "Jean Marie Stine",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27297,
                            Title = "The Prisoner #3:  A Day in the Life",
                            Year = 1970,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5692,
                    Name = "Susan Barker",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27334,
                            Title = "The Incarnations",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5757,
                    Name = "Thomas Pope",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 15931,
                            Title = "A Call to Arms",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 27898,
                            Title = "A Call to Vengeance",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5758,
                    Name = "Louis Sylvester",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27916,
                            Title = "Legends of the Lost Causes",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5783,
                    Name = "Krystal A. Smith",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 27994,
                            Title = "Two Moons: Stories",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5817,
                    Name = "Hye-young Pyun",
                    Nominations = 1,
                    Wins = 1,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28134,
                            Title = "The Hole:  A Novel",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 1,
                            Genres = new Genre[] { Genre.Horror }
                        },
                        new Book
                        {
                            ID = 35842,
                            Title = "City of Ash and Red",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5839,
                    Name = "Chloe Benjamin",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28258,
                            Title = "The Immortalists",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28259,
                            Title = "The Anatomy of Dreams: A Novel",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5841,
                    Name = "Betsy Wollheim",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28310,
                            Title = "Fantasy: DAW 30th Anniversary",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28311,
                            Title = "Science Fiction: DAW 30th Anniversary",
                            Year = 2002,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 5865,
                    Name = "Courtney Bird",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28445,
                            Title = "The Diamond Girl",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5868,
                    Name = "Sheree Ren├⌐e Thomas",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 28474,
                            Title = "Treesong",
                            Year = 2016,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 30345,
                            Title = "Shotgun Lullabies: Stories & Poems",
                            Year = 2011,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 28475,
                            Title = "Sleeping Under the Tree of Life",
                            Year = 2016,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17397,
                            Title = "Dark Matter: A Century of Speculative Fiction from the African Diaspora",
                            Year = 2000,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 17398,
                            Title = "Dark Matter:  Reading the Bones",
                            Year = 2004,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5960,
                    Name = "Minsoo Kang",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30192,
                            Title = "The Sacrifice of the Hanged Monkey",
                            Year = 2017,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5971,
                    Name = "Melissa Albert",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 30298,
                            Title = "The Hazel Wood",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35840,
                            Title = "The Night Country",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 5982,
                    Name = "James R. Mantague",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31406,
                            Title = "Worms",
                            Year = 1979,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 5995,
                    Name = "Gene Van Troyer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31540,
                            Title = "Speculative Japan:  Outstanding Tales of Japanese Science Fiction and Fantasy",
                            Year = 2007,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6004,
                    Name = "Ryan Kirk",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31618,
                            Title = "Nightblade's Vengeance",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31620,
                            Title = "Nightblade's Honor",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6023,
                    Name = "Nama Kwame Adjei-Brenyah",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31748,
                            Title = "Friday Black",
                            Year = 2018,
                            Type = BookType.Collection,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 6030,
                    Name = "Sarah Totton",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31774,
                            Title = "A Fish Story",
                            Year = 2006,
                            Type = BookType.ShortStory,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6041,
                    Name = "Teresa Edgerton",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31897,
                            Title = "The Queen's Necklace",
                            Year = 2001,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31898,
                            Title = "Child of Saturn",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31899,
                            Title = "The Moon in Hiding",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31900,
                            Title = "The Work of the Sun",
                            Year = 1990,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31901,
                            Title = "The Castle of the Silver Wheel",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31902,
                            Title = "The Grail and the Ring",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31904,
                            Title = "The Moon and the Thorn",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6046,
                    Name = "James De Mille",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31929,
                            Title = "A Strange Manuscript Found in a Copper Cylinder",
                            Year = 1888,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 6047,
                    Name = "C. Dale Brittain",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 31956,
                            Title = "A Bad Spell in Yurt",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31957,
                            Title = "The Wood Nymph and the Cranky Saint",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31958,
                            Title = "Mage Quest",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31959,
                            Title = "The Witch and the Cathedral",
                            Year = 1995,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 31960,
                            Title = "Daughter of Magic",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 6051,
                    Name = "Chris Marie Green",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 32009,
                            Title = "Only the Good Die Young",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32010,
                            Title = "Another One Bites the Dust",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 32011,
                            Title = "Every Breath You Take",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7159,
                    Name = "Imraan Coovadia",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33917,
                            Title = "A Spy in Time",
                            Year = 2018,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7165,
                    Name = "Temi Oh",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33971,
                            Title = "Do You Dream of Terra Two?",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7167,
                    Name = "Jeanne Larsen",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 33991,
                            Title = "Silk Road:  A Novel of Eighth-Century China",
                            Year = 1989,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 33992,
                            Title = "Bronze Mirror",
                            Year = 1991,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 33993,
                            Title = "Manchu Palaces",
                            Year = 1996,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7171,
                    Name = "Libia Brenda",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34000,
                            Title = "A Larger Reality",
                            Year = 2018,
                            Type = BookType.Anthology,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                        new Book
                        {
                            ID = 34001,
                            Title = "The Mexicanx Initiative:  The Mexicanx Experience at Worldcon 76",
                            Year = 2018,
                            Type = BookType.Miscellaneous,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy, Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 7200,
                    Name = "Valdimar Asmundsson",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34189,
                            Title = "Powers of Darkness:  The Lost Version of Dracula",
                            Year = 1900,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 7207,
                    Name = "Daniel M. Bensen",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34252,
                            Title = "Junction",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7218,
                    Name = "Craig Mills",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34315,
                            Title = "Shadow of the Crown",
                            Year = 1993,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34313,
                            Title = "The Bane of Lord Caladon",
                            Year = 1982,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 34314,
                            Title = "The Dreamer in Discord",
                            Year = 1988,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7252,
                    Name = "Ron Currie, Jr.",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34450,
                            Title = "God is Dead",
                            Year = 2007,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7351,
                    Name = "Rena Barron",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34784,
                            Title = "Kingdom of Souls",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7354,
                    Name = "Will Hubbell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34792,
                            Title = "Cretaceous Sea",
                            Year = 2002,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 34793,
                            Title = "Sea of Time",
                            Year = 2004,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7357,
                    Name = "Carolyn See",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34805,
                            Title = "Golden Days",
                            Year = 1986,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7373,
                    Name = "Robert Nichols",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 34897,
                            Title = "Daily Lives in Nghsi-Altai",
                            Year = 1977,
                            Type = BookType.Omnibus,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7399,
                    Name = "Stephanie T. Hoppe",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35066,
                            Title = "The Windrider",
                            Year = 1985,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7439,
                    Name = "William March",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35212,
                            Title = "The Bad Seed",
                            Year = 1954,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Horror }
                        },
                    }
                },
                new Author
                {
                    ID = 7464,
                    Name = "Kristyn Merbeth",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35322,
                            Title = "Fortuna",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7489,
                    Name = "William O'Farrell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35408,
                            Title = "Repeat Performance",
                            Year = 1942,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7578,
                    Name = "James Maxwell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35857,
                            Title = "Enchantress",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35858,
                            Title = "The Hidden Relic",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35859,
                            Title = "The Path of the Storm",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 35860,
                            Title = "The Lore of the Evermen",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7583,
                    Name = "Sean Ferrell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35878,
                            Title = "Man in the Empty Suit",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7584,
                    Name = "Lauren Kate",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 35884,
                            Title = "Fallen",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7616,
                    Name = "Carolyn Hart",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36038,
                            Title = "Ghost at Work",
                            Year = 2008,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36039,
                            Title = "Merry, Merry Ghost",
                            Year = 2009,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36040,
                            Title = "Ghost in Trouble",
                            Year = 2010,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36041,
                            Title = "Ghost Gone Wild",
                            Year = 2013,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36042,
                            Title = "Ghost Wanted",
                            Year = 2014,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36043,
                            Title = "Ghost to the Rescue",
                            Year = 2015,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36044,
                            Title = "Ghost Times Two",
                            Year = 2016,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                        new Book
                        {
                            ID = 36045,
                            Title = "Ghost on the Case",
                            Year = 2017,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7646,
                    Name = "Beth Overmeyer",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36164,
                            Title = "The Goblets Immortal",
                            Year = 2020,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7649,
                    Name = "Timur Vermes",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36176,
                            Title = "Look Who's Back",
                            Year = 2012,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7685,
                    Name = "Gillian Polack",
                    Nominations = 1,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36337,
                            Title = "The Year of the Fruit Cake",
                            Year = 2019,
                            Type = BookType.Novel,
                            Nominations = 1,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7727,
                    Name = "Nicholson Baker",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36442,
                            Title = "The Fermata",
                            Year = 1994,
                            Type = BookType.Novel,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction, Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7750,
                    Name = "Jochen Ecke",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36516,
                            Title = "Comics as a Nexus of Cultures:  Essays on the Interplay of Media, Disciple and International Perspectives",
                            Year = 2010,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                        new Book
                        {
                            ID = 36517,
                            Title = "The British Comic Book Invasion:  Alan Moore, Warren Ellis, Grant Morrison and the Evolution of the American Style",
                            Year = 2019,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7752,
                    Name = "K├íroly Pint├⌐r",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36518,
                            Title = "The Anatomy of Utopia:  Narration, Estrangement and Ambiguity in More, Well, Huxley and Clarke",
                            Year = 2010,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.ScienceFiction }
                        },
                    }
                },
                new Author
                {
                    ID = 7762,
                    Name = "Peter Hunt",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36532,
                            Title = "The Fabulous Journeys of Alice and Pinocchio:  Exploring Their Parallel Worlds",
                            Year = 2018,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
                new Author
                {
                    ID = 7796,
                    Name = "William C. Spruiell",
                    Nominations = 0,
                    Wins = 0,
                    Books = new List<Book>
                    {
                        new Book
                        {
                            ID = 36597,
                            Title = "Discworld and the Disciplines:  Critical Approaches to the Terry Pratchett Works ",
                            Year = 2014,
                            Type = BookType.NonFiction,
                            Nominations = 0,
                            Wins = 0,
                            Genres = new Genre[] { Genre.Fantasy }
                        },
                    }
                },
            };
        }
    }
}

