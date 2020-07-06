using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class11.NullableTypes
{
    public class User
    {
        // required
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

        //optional
        public Nullable<long> EMB { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<bool> IsActive { get; set; }

        // nullable new way
        public DateTime? DateOfBirth { get; set; }
        public DateTime DateOfBirthNotNull { get; set; }
    }
}
