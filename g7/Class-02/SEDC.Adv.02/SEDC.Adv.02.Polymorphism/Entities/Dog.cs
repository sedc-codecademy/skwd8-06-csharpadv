using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._02.Polymorphism.Entities
{
	public class Dog : Pet
	{
		public bool IsGoodBoi { get; set; }

		public override void Eat()
		{
			Console.WriteLine("Nom nom nom nomming dog food!");
		}
	}
}
