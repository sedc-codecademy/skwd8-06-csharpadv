using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Interfaces;

namespace TryBeingFit.Domain.Core.Entities
{
    public class PremiumUser : User, IPremiumUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
