using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using TryBeingFit.Domain.Core.Entities;

namespace TryBeingFit.Services.Services
{
    public interface IUserService<T> where T : User
    {
        void ChangePassword(int userId, string oldPassword, string newPassword);
        void ChangeInfo(int userId, string firstName, string lastName);
        T Login(string username, string password);
        T Register(T user);
    }
}
