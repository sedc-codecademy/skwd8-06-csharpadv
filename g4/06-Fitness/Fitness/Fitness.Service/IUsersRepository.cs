using Fitness.Models;

using System.Collections.Generic;

namespace Fitness.Service
{
    public interface IUsersRepository
    {
        bool CheckUserNameAvailability(string username);

        StandardUser RegisterUser(string firstName, string lastname, string username, string password);

        bool CheckUserCredentials(string username, string password);

        IApplicationUser LoginInUser(string username, string password);

        bool LogOffUser(IApplicationUser user);

        IEnumerable<IApplicationUser> GetLoggedUsers();
    }
}