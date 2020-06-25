using SEDC.Exercise.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public class LiveTraining : Training, ILiveTraining, IVideoTraining
    {
        public DateTime NextSession { get; set; }

        public TrainerUser Trainer { get; set; }

        public string CheckRating()
        {
            throw new NotImplementedException();
        }

        public int HoursToNextSession()
        {
            return 0;
        }

        public override string Print()
        {
            return $"[{Difficulty}]{Title} - {Description} with {Trainer.Print()}";
        }
    }
}
