using InterfacesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp.Entities
{
    public class Developer : Employee, ICoder, ICook
    {
        public List<string> Languages { get; set; }
        public List<string> Frameworks { get; set; }
        public string Food { get; set; }

        public void Code()
        {
            Console.WriteLine($"{FullName} - Started Coding...!!!!");
        }

        public void Cook()
        {
            Console.WriteLine($"{FullName} - is cooking {Food}");
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
