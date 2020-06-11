using InterfacesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp.Entities
{
    public class QA : Employee, ICoder
    {
        public List<string> Bugs { get; set; }
        public List<string> Languages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Code()
        {
            Console.WriteLine($"QA Guy/Girl {DNA} is coding!!!");
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
