using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    // BaseEntity does not get angry because we do not implement Info() abstract method
    // It will only get angry IF the class it inherits from BaseEntity is a standard class
    public abstract class User : BaseEntity, IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
