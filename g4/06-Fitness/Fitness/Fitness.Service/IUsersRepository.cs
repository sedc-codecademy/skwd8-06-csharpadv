using Fitness.Models;

namespace Fitness.Service
{
    public interface IUsersRepository
    {
        StandardUser RegisterUser(string firstName, string lastname, string username, string password);

        bool CheckUserCredentials(string username, string password);

        IApplicationUser LoginInUser(string username, string password);

        bool LogOffUser(IApplicationUser user);
    }
}