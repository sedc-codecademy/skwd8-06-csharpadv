using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class Trainer : User
    {
        public Trainer()
        {
            Console.WriteLine("Trainer is born");

        }
        public string CurrentSubject { get; set; }

        public override void SayHi()
        {
            Console.WriteLine($"Hi my name is {Name} and I'm trainer");
        }
    }
}
