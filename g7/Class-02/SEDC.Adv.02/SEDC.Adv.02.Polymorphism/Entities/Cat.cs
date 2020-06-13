using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._02.Polymorphism.Entities
{
	public class Cat : Pet
	{
		public bool IsLazy { get; set; }

		public override void Eat()
		{
			Console.WriteLine("Nom nom nomming on cat food!");
		}
	}
}
