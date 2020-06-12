using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class02.BoxingUnboxing.Entities
{
	public class Employee
	{
		public string FullName { get; set; }
		public string Company { get; set; }
		public string GetInfo() 
		{
			return $"{FullName} from {Company} company";
		}
	}
}
