using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public class VideoTraining : Training, IVideoTraining
    {
        public int Rating { get; set; }

        public string CheckRating()
        {
            return Rating == 1 ? "Bad" : 
                   Rating <= 3 ? "Okay" : 
                   Rating > 3 ? "Good" : "Unknown";
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
