using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.Exercise.Entities
{
	public class Fish : Pet
	{
		public string Color { get; set; }
		public int Size { get; set; }

		public Fish(string name, int age, string color, int size) : base(name, age)
		{
			Color = color;
			Size = size;
			Type = "Fish";
		}
		public override string PrintInfo()
		{
			return $"[{Type}] {Name} and is {Color}!";
		}
	}
}
