using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.StaticClassesAndPolymorphism.Polymorphism
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public override void Speak()
        {
            Console.WriteLine("Meow, meow!!!");
        }
    }
}
