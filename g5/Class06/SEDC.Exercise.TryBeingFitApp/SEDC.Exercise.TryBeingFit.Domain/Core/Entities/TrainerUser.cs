using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Entities
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsExperience { get; set; }
        public TrainerUser()
        {
            Role = UserRole.Trainer;
        }

        public bool ChangeSchedule()
        {
            //To DO : Provide implementation
            return false;
        }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
