namespace AuthorsCustom
{
    public class Book
    {
        public int ID { get; set; }

        [SsfFieldName("Naslov")]
        public string Title { get; set; }
        public int Year { get; set; }
        public int Nominations { get; set; }
        public int Wins { get; set; }

        [SsfIgnore]
        public string ImageName { get; set; }
        public BookType Type { get; set; }
        public Genre[] Genres { get; set; }

        public override string ToString()
        {
            return $"#{ID}: {Title}";
        }
    }
}