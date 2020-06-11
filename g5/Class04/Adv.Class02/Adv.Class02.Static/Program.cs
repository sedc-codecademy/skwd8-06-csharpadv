using System;

namespace Adv.Class02.Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Song coldplay = new Song("Champion of the World", "Coldplay", 150);
            Console.WriteLine(Song.songCounter);

            Song kygo = new Song("Sunrise", "Kygo", 200);
            Song garix = new Song("High on Life", "Martin Garix", 180);

            Console.WriteLine(Song.songCounter);

            Console.WriteLine(coldplay.artist);
            Console.WriteLine(kygo.artist);
            Console.WriteLine(Song.songCounter);
        }
    }
}
