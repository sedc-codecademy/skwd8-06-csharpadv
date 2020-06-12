using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class02.BoxingUnboxing.Entities
{
	public class Tester : Employee
	{
		public int BugsFound { get; set; }
		public void Test()
		{
			Console.WriteLine("Running tests...");
		}
	}
}
