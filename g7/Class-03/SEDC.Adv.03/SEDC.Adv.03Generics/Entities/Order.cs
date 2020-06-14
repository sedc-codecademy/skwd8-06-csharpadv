using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Entities
{
	public class Order : BaseEntity
	{
		public string Receiver { get; set; }
		public string Address { get; set; }
		// Order inherits from BaseEntity and therefore IT MUST WRITE THE CODE FOR IT
		// In the method we add some stuff that are unique to this class ( Receiver and Address )
		public override string GetInfo()
		{
			return $"{Id}) {Receiver} - {Address}";
		}
	}
}
