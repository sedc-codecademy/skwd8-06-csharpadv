using SEDC.Exercise.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }

        public int HoursToNextSession()
        {
            return 0;
        }


    }
}
