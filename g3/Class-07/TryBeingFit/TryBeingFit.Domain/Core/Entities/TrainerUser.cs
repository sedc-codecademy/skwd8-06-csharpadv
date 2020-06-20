using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Interfaces;

namespace TryBeingFit.Domain.Core.Entities
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsExperience { get; set; }
        public bool ChangeSchedule(ILiveTraining liveTraining)
        {
            Console.WriteLine("The schedule has been changed");
            throw new NotImplementedException();
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
