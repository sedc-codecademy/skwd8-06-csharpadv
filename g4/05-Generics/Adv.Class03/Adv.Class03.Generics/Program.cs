using Adv.Class03.Generics.Entities;
using Adv.Class03.Generics.Helpers;
using System;
using System.Collections.Generic;

namespace Adv.Class03.Generics
{
	class Program
	{
        public static GenericDb<Order> OrderDb = new GenericDb<Order>();
        public static GenericDb<Product> ProductDb = new GenericDb<Product>();
        static void Main(string[] args)
        {
            #region Not Generic Helpers
            NotGenericListHelper NotGeneric = new NotGenericListHelper();
            List<string> strings = new List<string>() { "str1", "str2", "str3" };
            List<int> ints = new List<int>() { 5, 22, -18 };
            List<bool> bools = new List<bool> { true, false, true };
            NotGeneric.GoThroughStrings(strings);
            NotGeneric.GetInfoForStrings(strings);
            NotGeneric.GoThroughInts(ints);
            NotGeneric.GetInfoForInts(ints);
            #endregion
            #region Generic Helpers
            // For non static methods ( Uncomment only if you remove static from the methods )
            //GenericListHelper<string> genericHelper1 = new GenericListHelper<string>();
            //GenericListHelper<int> genericHelper2 = new GenericListHelper<int>();
            //GenericListHelper<bool> genericHelper3 = new GenericListHelper<bool>();

            //genericHelper1.GoThrough(strings);
            //genericHelper1.GetInfo(strings);

            //genericHelper2.GoThrough(ints);
            //genericHelper2.GetInfo(ints);

            //genericHelper3.GoThrough(bools);
            //genericHelper3.GetInfo(bools);

            // For static methods
            GenericListHelper<string>.GoThrough(strings);
            GenericListHelper<string>.GetInfo(strings);

            GenericListHelper<int>.GoThrough(ints);
            GenericListHelper<int>.GetInfo(ints);

            GenericListHelper<bool>.GoThrough(bools);
            GenericListHelper<bool>.GetInfo(bools);
            #endregion
            #region Generic Classes
            OrderDb.Insert(new Order() { Id = 1, Address = "Bob street 29", Receiver = "Bob" });
            OrderDb.Insert(new Order() { Id = 2, Address = "Jill street 31", Receiver = "Jill" });
            OrderDb.Insert(new Order() { Id = 3, Address = "Greg street 11", Receiver = "Greg" });
            ProductDb.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });
            ProductDb.Insert(new Product() { Id = 2, Description = "Mechanical", Title = "Keyboard" });
            ProductDb.Insert(new Product() { Id = 3, Description = "64GB", Title = "USB" });
            Console.WriteLine("Orders:");
            OrderDb.PrintAll();
            Console.WriteLine("Produts:");
            ProductDb.PrintAll();
            Console.WriteLine("-------Get by id 1 from Order and Product-------");
            Console.WriteLine(OrderDb.GetById(1).GetInfo());
            Console.WriteLine(ProductDb.GetById(1).GetInfo());
            Console.WriteLine("-------Get by index 1 from Order and Product-------");
            Console.WriteLine(OrderDb.GetByIndex(1).GetInfo());
            Console.WriteLine(ProductDb.GetByIndex(1).GetInfo());
            Console.WriteLine("-------Remove by id 1 from Order and Product-------");
            OrderDb.RemoveById(1);
            ProductDb.RemoveById(1);
            Console.WriteLine("Orders:");
            OrderDb.PrintAll();
            Console.WriteLine("Products:");
            ProductDb.PrintAll();
            Console.ReadLine();
            #endregion
        }
    }
}
