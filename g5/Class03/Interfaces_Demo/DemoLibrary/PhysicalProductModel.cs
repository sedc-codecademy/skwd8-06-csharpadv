using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// Class that inherits from the base class ProductModelBase(it is empty) and implements an interface
    /// called IProductModel. Class needs to provide implementation for all the members in that interface.
    /// Please note that, when we inherit from a class and implement an interface, class name should be first
    /// then interfaces. If we put first interface name after ':' we will get a compile time error..
    /// </summary>
    public class PhysicalProductModel : ProductModelBase, IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get;  set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
