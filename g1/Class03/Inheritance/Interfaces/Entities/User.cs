using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    public abstract class User : IUser
    {
        public string Name { get; set; }
        public int Age { get; set; }

        #region IUser methods
        public int GetAge()
        {
            return Age;
        }

        // because User is abstract class we can set SayHi method from IUser like an abstract
        // method, which means we wont do the implementation of the method here
        // but in the class that will inherit from User
        public abstract void SayHi();

        public void SetName(string name)
        {
            Name = name;
        }
        #endregion

        // despite methods implemented from interface classes can have their own methods too
        public void SaySomethingElse()
        {
            Console.WriteLine("something else");
        }
    }
}
