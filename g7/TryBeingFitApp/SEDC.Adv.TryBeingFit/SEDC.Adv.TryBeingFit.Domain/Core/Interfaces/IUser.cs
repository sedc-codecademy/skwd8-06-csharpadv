using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
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
