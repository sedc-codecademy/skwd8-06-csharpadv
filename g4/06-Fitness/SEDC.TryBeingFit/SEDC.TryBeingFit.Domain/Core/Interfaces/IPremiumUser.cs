using SEDC.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core
{
	public interface IPremiumUser
	{
		LiveTraining LiveTraining { get; set; }
	}
}
