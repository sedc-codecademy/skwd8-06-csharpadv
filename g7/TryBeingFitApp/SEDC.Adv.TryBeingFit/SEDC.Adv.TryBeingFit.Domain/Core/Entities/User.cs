using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    // BaseEntity does not get angry because we do not implement Info() abstract method
    // It will only get angry IF the class it inherits from BaseEntity is a standard class
    public abstract class User : BaseEntity, IUser
    {
        // Validation types:
        // Type 1: Length
        // Type 2: Does not contain numbers
        // Type 3: Remove spaces
        // Type 4: Has at least one number

        // Type 1
        // Type 2
        // Type 3
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Type 1
        // Type 3
        public string Username { get; set; }

        // Type 1
        // Type 3
        // Type 4
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
