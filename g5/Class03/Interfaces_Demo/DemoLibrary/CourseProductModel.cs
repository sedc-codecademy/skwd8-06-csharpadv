using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    /// <summary>
    /// Client wanted us to extend the solution and add new functionallity with introducing new 
    /// ProductModel called Course. Therefore, we just create a new class, implement the interface we 
    /// already have called IProductModel and provide implementation for all the members from the interface.
    /// </summary>
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Added the {Title} course to {customer.FirstName} account.");
            }
        }
    }
}
