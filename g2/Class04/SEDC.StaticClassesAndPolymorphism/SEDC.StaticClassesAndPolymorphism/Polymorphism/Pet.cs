using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.StaticClassesAndPolymorphism.Polymorphism
{
    public class Pet
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("The pet speaks its own language");
        }
    }
}
