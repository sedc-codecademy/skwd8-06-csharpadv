using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Enums;

namespace TryBeingFit.Domain.Core.Entities
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        UserRole Role { get; set; }
    }
}
