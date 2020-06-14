using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Entities
{
	public class Product : BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		// Product inherits from BaseEntity and therefore IT MUST WRITE THE CODE FOR IT
		// In the method we add some stuff that are unique to this class ( Title and Description )
		public override string GetInfo()
		{
			return $"{Id}) {Title} - {Description}";
		}
	}
}
