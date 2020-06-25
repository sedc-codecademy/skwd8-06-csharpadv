using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Delegates
{
    public class Shop
    {
        public Shop()
        {
            InformCustomers += () => Console.WriteLine("Customers informed");
            //InformCustomers += () => Console.WriteLine("Customers informed 2");
            InformCustomers += () => Console.WriteLine("test inform");
        }

        #region Func
        Func<int, string> Func = x => x.ToString();
        Func2<int, string> Func2 = x => x.ToString();
        Func2<int, int, string> Func3 = (p1, p2) => $"{p1} - {p2}";
        #endregion

        public Inform InformCustomers { get; set; }

        public string Name { get; set; }
        public DateTime WorkingHours { get; set; }
        public int Size { get; set; }
        public int Availablity { get; set; }

        public void ReorderProducts()
        {
            Console.WriteLine($"Doing a reorder {Func(2)}");
        }
    }

    public delegate void Inform();

    public delegate Output Func2<Param1, Output>(Param1 param);
    public delegate Output Func2<Param1, Param2, Output>(Param1 param1, Param2 param2);
}
