using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExample.Enteties
{
    public abstract class Store
    {
        public List<string> Products { get; set; }
        public string Adress { get; set; }

        public void ShowProductsMenu()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
