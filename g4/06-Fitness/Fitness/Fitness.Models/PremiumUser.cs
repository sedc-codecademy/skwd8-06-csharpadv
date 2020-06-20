using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Models
{
    public class PremiumUser: FitnessUser, IApplicationUser
    {
        public PremiumUser(StandardUser standard)
        {
            ID = standard.ID;
            FirstName = standard.FirstName;
            LastName = standard.LastName;
            UserName = standard.UserName;
            Password = standard.Password;
        }

        public void StartLiveTraining()
        {
            Console.WriteLine("Starting video training");
        }

        public override void StartVideoTraining()
        {
            Console.WriteLine($"Starting video training in hi-def for user {FullName}");
        }
    }
}
