using Fitness.Models;
using System;
using System.Collections.Generic;

namespace Fitness.Service
{
    public class MemoryUsersRepository : IUsersRepository
    {
        public MemoryUsersRepository(IEnumerable<IApplicationUser> initialUsers)
        {

        }
        public bool CheckUserCredentials(string username, string password)
        {
            throw new NotImplementedException();
        }

        public IApplicationUser LoginInUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool LogOffUser(IApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public StandardUser RegisterUser(string firstName, string lastname, string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
