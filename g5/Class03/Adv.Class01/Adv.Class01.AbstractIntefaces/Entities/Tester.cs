using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class02.AbstractIntefaces.Entities
{
	public class Tester : Human, ITester
	{
		public int BugsFound { get; set; }
		public void TestFeature(string feature)
		{
			Console.WriteLine($"{feature} is being tested...");
			Console.WriteLine("Testing complete!");
		}
		public Tester(string fullname, int age, long phone, int bugs)
			: base(fullname, age, phone)
		{
			BugsFound = bugs;
		}
		public override string GetInfo()
		{
			return $"{FullName} ({Age}) - found {BugsFound} bugs to date!";
		}
	}
}
