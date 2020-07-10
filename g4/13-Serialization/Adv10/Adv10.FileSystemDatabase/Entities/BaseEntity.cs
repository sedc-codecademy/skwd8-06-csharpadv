using System;
using System.Collections.Generic;
using System.Text;

namespace Adv10.FileSystemDatabase
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public abstract string Info();
	}
}
