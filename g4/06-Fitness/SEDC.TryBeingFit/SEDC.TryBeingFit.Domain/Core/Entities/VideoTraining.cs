using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public class VideoTraining : Training, IVideoTraining
	{
		public string Link { get; set; }
		public int Rating { get; set; }

		public override string Print()
		{
			throw new NotImplementedException();
		}
		public string CheckRating()
		{
			if (Rating == 1) return "Bad";
			if (Rating < 3) return "Okay";
			if (Rating > 3) return "Good";
			return "Unknown";
		}
	}
}
