using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public class PremiumUser : User, IPremiumUser
    {
        public List<VideoTraining> VideoTrainigs { get; set; }
        public LiveTraining LiveTraining { get; set; }
        public PremiumUser()
        {
            Role = UserRole.Premium;
        }
        public override string Info()
        {
            return $"{FirstName} {LastName} - A premium user!";
        }
    }
}
