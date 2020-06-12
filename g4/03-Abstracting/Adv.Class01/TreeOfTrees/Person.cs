using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfTrees
{
    public class Person : Object
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
