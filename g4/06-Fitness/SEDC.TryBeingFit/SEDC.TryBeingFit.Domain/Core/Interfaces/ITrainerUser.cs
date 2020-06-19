using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core
{
	public interface ITrainerUser
	{
		bool ChangeSchedule(ILiveTraining liveTraining);
	}
}
