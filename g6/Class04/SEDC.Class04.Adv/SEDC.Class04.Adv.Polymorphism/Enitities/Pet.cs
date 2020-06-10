using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class04.Adv.Polymorphism.Enitities
{
    public class Pet
    {
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("nom nom nom");
        }

        public virtual string MakeSomeBigCalcultions()
        {
            return string.Empty;
        }
    }
}
