using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsExperience { get; set; }
        public TrainerUser()
        {
            Role = UserRole.Trainer;
        }
        public bool ChangeSchedule(LiveTraining liveTraining)
        {
            throw new NotImplementedException();
        }

        public override string Info()
        {
            throw new NotImplementedException();
        }
    }
}
