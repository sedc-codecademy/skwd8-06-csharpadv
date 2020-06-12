using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class02.BoxingUnboxing.Entities
{
	public class Developer : Employee
	{
		public int Level { get; set; }
		public void Code()
		{
			Console.WriteLine("tak tak tak");
		}
	}
}
