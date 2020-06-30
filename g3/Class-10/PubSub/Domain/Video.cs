using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Video
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string VideoData { get; set; }
    }
}
