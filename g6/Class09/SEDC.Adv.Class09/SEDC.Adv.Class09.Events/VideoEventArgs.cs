using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class09.Events
{
    public class VideoEventArgs : EventArgs
    {
        public Movie Movie { get; set; }
    }

    public class Movie
    {
        public string Title { get; set; }
    }
}
