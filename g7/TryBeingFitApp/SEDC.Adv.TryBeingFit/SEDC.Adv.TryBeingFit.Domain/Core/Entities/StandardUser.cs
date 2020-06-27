using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser()
        {
            Role = UserRole.Standard;
        }
        public override string Info()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
