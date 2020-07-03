
using System;
using System.Collections.Generic;
using System.Text;

namespace Finalizer
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        ~Person()
        {
            Console.WriteLine("Help! I'm being finalized");
        }

    }
}
