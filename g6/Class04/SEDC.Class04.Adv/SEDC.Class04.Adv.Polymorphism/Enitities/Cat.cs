using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class04.Adv.Polymorphism.Enitities
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }

        public override void Eat()
        {
            Console.WriteLine("nom nom noming on cat food!");
            base.Eat();
        }

        public void SayHello()
        {
            Console.WriteLine("Cat is greeting you.");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name} from cat :)");
        }
    }
}
