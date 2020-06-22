using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Entities;

namespace TryBeingFit.Domain.Core.Interfaces
{
    public interface IPremiumUser
    {
        LiveTraining LiveTraining { get; set; }
    }
}
