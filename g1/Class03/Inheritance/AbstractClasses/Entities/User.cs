using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public abstract class User
    {
        public User()
        {
            Console.WriteLine("User is born");
        }
        public string Name { get; set; }
        public int Age { get; set; } = 18;

        public abstract void SayHi();
    }
}
