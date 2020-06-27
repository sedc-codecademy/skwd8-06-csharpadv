using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public interface ITrainerUser
    {
        bool ChangeSchedule(LiveTraining liveTraining, int days);
    }
}
