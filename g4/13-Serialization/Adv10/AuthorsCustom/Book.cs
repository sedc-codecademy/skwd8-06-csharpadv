namespace AuthorsCustom
{
    public class Book
    {
        public int ID { get; internal set; }

        [SsfFieldName("Naslov")]
        public string Title { get; internal set; }
        public int Year { get; internal set; }
        public int Nominations { get; internal set; }
        public int Wins { get; internal set; }

        [SsfIgnore]
        public string ImageName { get; internal set; }
        public BookType Type { get; internal set; }
        public Genre[] Genres { get; internal set; }
    }
}