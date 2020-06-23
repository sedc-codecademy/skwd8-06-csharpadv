using System;
using System.Collections.Generic;
using System.Text;

namespace Adv._05.Helpers
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public abstract string Info();
	}
}
