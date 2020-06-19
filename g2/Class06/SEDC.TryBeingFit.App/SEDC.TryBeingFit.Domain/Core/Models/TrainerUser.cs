using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Models
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsOfExperience { get; set; }

        public TrainerUser()
        {
            Role = UserRole.Trainer;
        }

        public bool ChangeSchedule(ILiveTraining liveTraining)
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
