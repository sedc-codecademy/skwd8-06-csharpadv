using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv05.Domain
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public abstract string Info();
	}
}
