using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp.Entities
{
    public abstract class Employee : Human
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public void Print()
        {
            Console.WriteLine($"{Id} - {FullName}");
        }

        public abstract string GetInfo();
    }
}
