using AuthorsCustom;

using NUnit.Framework;

using System.Collections.Generic;

namespace AuthorsCustomTests
{
    public class SerializationTests
    {
        [SetUp]
        public void Setup()     // beforeEach
        {
        }

        [TearDown]
        public void TearDown()     // afterEach
        {
        }

        [Test]
        public void Test_that_an_author_without_books_serializes_successfully()
        {
            // 1. Arrange
            var andyWeir = new Author
            {
                ID = 2220,
                Name = "Andy Weir",
                Nominations = 2,
                Wins = 0,
                Books = new List<Book> {}
            };

            var expected =
                @"Author:
    ID = 2220
    Nominations = 2
    Wins = 0
    Name = ""Andy Weir""
    Books =
";

            // 2. Act
            var actual = SedcSerialization.Serialize(andyWeir);

            // 3. Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_that_a_book_serializes_successfully()
        {
            // 1. Arrange
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

            var expected =
                @"Book:
    ID = 36075
    Year = 2019
    Nominations = 0
    Wins = 0
    Naslov = ""Randomize""
";

            // 2. Act
            var actual = SedcSerialization.Serialize(randomize);

            // 3. Assert
            Assert.AreEqual(expected, actual);
        }
    }
}