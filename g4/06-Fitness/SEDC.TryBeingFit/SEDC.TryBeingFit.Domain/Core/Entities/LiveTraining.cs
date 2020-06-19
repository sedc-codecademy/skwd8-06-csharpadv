using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public class LiveTraining : Training, ILiveTraining, IVideoTraining
	{
		public DateTime NextSession { get; set; }
		public TrainerUser Trainer { get; set; }
		public string CheckRating()
		{
			throw new NotImplementedException();
		}

		public int HoursToNextSession()
		{
			throw new NotImplementedException();
		}

		public override string Print()
		{
			throw new NotImplementedException();
		}
	}
}
