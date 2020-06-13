using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Entities
{
	public class Order : BaseEntity
	{
		public string Reciever { get; set; }
		public string Address { get; set; }
		public override string GetInfo()
		{
			return $"{Id}) {Reciever} - {Address}";
		}
	}
}
