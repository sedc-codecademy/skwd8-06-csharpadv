using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public class VideoTraining : Training, IVideoTraining
    {
        public string Link { get; set; }
        public int Rating { get; set; }
        public string CheckRating()
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
