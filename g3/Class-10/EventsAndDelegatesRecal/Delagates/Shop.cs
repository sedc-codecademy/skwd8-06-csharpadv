using System;
using System.Collections.Generic;
using System.Text;

namespace Delagates
{
    public class Shop
    {
        public string Name { get; set; }

        public event InformCustomers Inform;

        public void AddMethodToDelegate(InformCustomers informCustomers)
        {
            Inform += informCustomers;
        }
    }

    public delegate void InformCustomers();
}
