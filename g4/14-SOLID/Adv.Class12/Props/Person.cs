
using System;
using System.Collections.Generic;
using System.Text;

namespace Props
{
    class Person
    {
        public int Age;

        public string FirstName { get; set; }

        private string __lastName;

        public string LastName
        {
            get => __lastName;
            set => __lastName = value;
        }

        // Same as a property
        public string GetLastName() => __lastName;
        public void SetLastName(string value) => __lastName = value;


        private int __age;

        public int GetAge2() => __age;
        public void SetAge2(int value) => __age = value;

        public int Age3 { get; set; }

    }
}
