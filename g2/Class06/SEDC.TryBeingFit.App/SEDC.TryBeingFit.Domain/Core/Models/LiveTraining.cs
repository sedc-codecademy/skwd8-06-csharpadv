using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public class LiveTraining : Training, ILiveTraining, IVideoTraining
    {
        public DateTime NextSession { get; set; }
        public string Trainer { get; set; }

        public string CheckRating()
        {
            throw new NotImplementedException();
        }

        public int HoursToNextSession()
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
