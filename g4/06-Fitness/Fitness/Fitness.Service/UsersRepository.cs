using Fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fitness.Service
{
    public class MemoryUsersRepository : IUsersRepository
    {
        private List<IApplicationUser> localUsers;
        private int nextUserId;

        public MemoryUsersRepository(IEnumerable<IApplicationUser> initialUsers)
        {
            localUsers = new List<IApplicationUser>(initialUsers);
            nextUserId = (localUsers.Count > 0) ? localUsers.Max(user => user.ID)+1 : 1;
        }
        public bool CheckUserCredentials(string username, string password)
        {
            return localUsers.Any(user => user.UserName == username && user.Password == password);
        }

        public IEnumerable<IApplicationUser> GetLoggedUsers()
        {
            return localUsers.Where(user => user.IsLoggedIn);
        }

        public IApplicationUser LoginInUser(string username, string password)
        {
            var loggedUser = localUsers.SingleOrDefault(user => user.UserName == username && user.Password == password);
            if (loggedUser == null)
            {
                throw new FitnessException("Invalid username or password");
            }
            loggedUser.Login();
            return loggedUser;
        }

        public bool LogOffUser(IApplicationUser user)
        {
            user.Logoff();
            return true;
        }

        public bool CheckUserNameAvailability(string username)
        {
            return localUsers.All(user => user.UserName != username);
        }

        public StandardUser RegisterUser(string firstName, string lastname, string username, string password)
        {
            if (localUsers.Any(user => user.UserName == username))
            {
                throw new FitnessException("Username already exists");
            }

            var createdUser = new StandardUser
            {
                ID = nextUserId,
                FirstName = firstName,
                LastName = lastname,
                UserName = username,
                Password = password
            };

            nextUserId += 1;

            localUsers.Add(createdUser);

            return createdUser;
        }
    }
}
