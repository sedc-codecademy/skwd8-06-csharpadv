using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.Polymorphism.Entities
{
	public class Cat : Pet
	{
		public bool IsLazy { get; set; }
		public override void Eat()
		{
			Console.WriteLine("Nom nom noming on cat food!");
		}
	}
}
