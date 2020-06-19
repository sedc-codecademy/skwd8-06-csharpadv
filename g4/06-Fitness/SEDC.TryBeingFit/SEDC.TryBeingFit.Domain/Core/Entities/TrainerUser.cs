using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public class TrainerUser : User, ITrainerUser
	{
		public int YearsExperience { get; set; }

		public TrainerUser()
		{
			Role = UserRole.Trainer;
		}
		public bool ChangeSchedule(ILiveTraining liveTraining)
		{
			throw new NotImplementedException();
		}

		public override string Print()
		{
			throw new NotImplementedException();
		}
	}
}
