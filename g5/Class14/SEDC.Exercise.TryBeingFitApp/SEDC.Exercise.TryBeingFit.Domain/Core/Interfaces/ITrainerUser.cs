using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Domain.Core.Enums
{
    public interface ITrainerUser
    {
        bool ChangeSchedule(LiveTraining liveTraining, int days);
    }
}
