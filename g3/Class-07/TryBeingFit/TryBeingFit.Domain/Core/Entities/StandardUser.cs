using System;
using System.Collections.Generic;
using System.Text;

namespace TryBeingFit.Domain.Core.Entities
{
    public class StandardUser : User
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public StandardUser()
        {
            Role = Enums.UserRole.Standard;
        }
        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
