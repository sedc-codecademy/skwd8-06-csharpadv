using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Entities
{
	public abstract class Training : BaseEntity, ITraining
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public int Time { get; set; }
		public Difficulty Difficulty { get; set; }
	}
}
