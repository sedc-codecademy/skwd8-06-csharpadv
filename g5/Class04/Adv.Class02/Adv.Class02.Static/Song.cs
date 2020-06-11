using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class02.Static
{
    public class Song
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCounter = 0;

        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCounter++;
        }
    }
}
