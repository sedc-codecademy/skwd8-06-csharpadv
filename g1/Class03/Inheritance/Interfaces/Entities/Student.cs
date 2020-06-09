using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    public class Student : User
    {
        public override void SayHi()
        {
            Console.WriteLine($"Hi my name is {Name}");
        }
    }
}
