using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._01.AbstractClasses.Entities
{
	public class Operations : Human, IOperations
	{
		public List<string> Projects { get; set; }
		public Operations(string fullName, int age, long phone, List<string> projects)
			: base(fullName, age, phone)
		{
			Projects = projects;
		}
		public bool CheckInfrastructure(int status)
		{
			// Arbitrary example code, the number 4 is not connected to a real world infrastructure
			// A dummy implementation
			if (status.ToString().StartsWith("4")) return false;
			return true;
		}

		public override string GetInfo()
		{
			return $"{FullName} ({Age}) - Currnetly working on {Projects.Count} projects!";
		}
	}
}
