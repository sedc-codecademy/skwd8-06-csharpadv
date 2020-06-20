using Fitness.Models;

using System;

namespace Fitness.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            UpgradeStandardToPremium();
        }

        private static void UpgradeStandardToPremium()
        {
            var standard = new StandardUser
            {
                ID = 1,
                FirstName = "Standard",
                LastName = "Standerson",
                UserName = "sstandard",
                Password = "sstandard"
            };

            var premium = new PremiumUser(standard);

            var result = (premium is PremiumUser);
            Console.WriteLine(result);
        }
    }
}
