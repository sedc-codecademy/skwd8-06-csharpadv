using System;

namespace Fitness.Models
{
    public class StandardUser: FitnessUser, IApplicationUser
    {
        public override void StartVideoTraining()
        {
            Console.WriteLine($"Starting video training in low-res for user {FullName}");
        }
    }
}
