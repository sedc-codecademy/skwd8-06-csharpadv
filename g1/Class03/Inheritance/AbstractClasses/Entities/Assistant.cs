using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class Assistant : User
    {
        public string[] Homeworks { get; set; }

        public override void SayHi()
        {
            Console.WriteLine($"Hi my name is {Name} and I am assistant");
        }
    }
}
