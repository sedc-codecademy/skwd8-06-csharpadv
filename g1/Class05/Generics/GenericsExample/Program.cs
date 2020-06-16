using GenericsExample.Enteties;
using System;

namespace GenericsExample
{
    class Program
    {
        public static GenericDB<Order> OrderDb = new GenericDB<Order>();
        public static GenericDB<Product> ProductDb = new GenericDB<Product>();
        static void Main(string[] args)
        {
            
            OrderDb.Insert(new Order() { Id = 1, Address = "Bob street 29", Receiver = "Bob" });
            OrderDb.Insert(new Order() { Id = 2, Address = "Jill street 31", Receiver = "Jill" });
            OrderDb.Insert(new Order() { Id = 3, Address = "Greg street 11", Receiver = "Greg" });
            ProductDb.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });
            ProductDb.Insert(new Product() { Id = 2, Description = "Mechanical", Title = "Keyboard" });
            ProductDb.Insert(new Product() { Id = 3, Description = "64GB", Title = "USB" });

            //Order order = OrderDb.GetElementById(1);
            //Console.WriteLine(order.Receiver);
            //Product product = ProductDb.GetElementById(2);
            //Console.WriteLine(product.Title);

            //OrderDb.PrintAll();
            //Console.WriteLine("-----------------");
            //ProductDb.PrintAll();
            OrderDb.RemoveById(3);
            OrderDb.PrintAll();
        }
    }
}
