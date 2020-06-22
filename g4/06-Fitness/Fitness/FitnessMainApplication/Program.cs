using Fitness.Models;
using Fitness.Service;

using System;
using System.Collections.Generic;

namespace FitnessMainApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region init
            List<IApplicationUser> initials = new List<IApplicationUser>
            {

            };
            IUsersRepository users = new MemoryUsersRepository(initials);
            #endregion

            // lots of code
            // users.
        }
    }
}
