
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Properties
{
    public class Person
    {
        private string firstName;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Value cannot be null or empty");
            }
            firstName = value;
        }

        public string LastName;

        private int age;

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public int Age
        {
            get 
            {
                return age;
            }
            set 
            {
                age = value;
            }
        }


    }
}
