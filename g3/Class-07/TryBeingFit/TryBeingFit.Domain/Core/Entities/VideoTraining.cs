using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Interfaces;

namespace TryBeingFit.Domain.Core.Entities
{
    public class VideoTraining : Training, IVideoTraining
    {
        public string Link { get; set; }
        public int Rating { get; set; }
        public string CheckRating()
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
