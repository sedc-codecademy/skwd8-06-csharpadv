using System;
using System.Collections.Generic;
using System.Text;

namespace TryBeingFit.Domain.Core.Interfaces
{
    public interface ITrainerUser
    {
        bool ChangeSchedule(ILiveTraining liveTraining);
    }
}
