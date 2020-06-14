using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Entities
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		// Every class that inherits from me MUST HAVE THIS METHOD AND MUST WRITE CODE FOR IT
		public abstract string GetInfo();
	}
}
