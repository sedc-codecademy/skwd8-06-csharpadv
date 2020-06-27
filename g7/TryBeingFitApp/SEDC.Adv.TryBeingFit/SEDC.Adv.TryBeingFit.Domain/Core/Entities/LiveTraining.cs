using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }
        public string Trainer { get; set; }

        public int HoursToNextSession()
        {
            return (NextSession - DateTime.Now).Hours;
        }

        public override string Info()
        {
            return $"[{Difficulty}]{Title} - {Description} with {Trainer.Print()}";
        }
    }
}
