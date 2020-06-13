using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.StaticClassesAndPolymorphism.Polymorphism
{
    public class Dog : Pet
    {
        public bool IsGoodBoy { get; set; }
        public override void Speak()
        {
            Console.WriteLine("Wooof, wooof!!!");
        }
    }
}
