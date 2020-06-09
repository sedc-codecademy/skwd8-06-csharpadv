using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddProductData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if(prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left..");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Andrej",
                LastName = "Chichakovski",
                City = "Skopje",
                EmailAddress = "andrejchichak@gmail.com",
                PhoneNumber = "12345"
            };
        }

        private static List<IProductModel> AddProductData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Mobile phone" });
            output.Add(new PhysicalProductModel { Title = "Tennis racket" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "C# Advanced Book" });
            output.Add(new CourseProductModel { Title = ".Net Core and C#" });

            return output;
        }
    }
}
