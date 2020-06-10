using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class04.Adv.Polymorphism.Enitities
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }

        public override void Eat()
        {
            Console.WriteLine("nom nom noming on dog food!");
        }

        public override string MakeSomeBigCalcultions()
        {
            return "Happy face";
        }
    }
}
