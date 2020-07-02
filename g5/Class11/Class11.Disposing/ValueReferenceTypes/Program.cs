using System;
using System.Collections;

namespace ValueReferenceTypes
{
    class Program
    {
        // where T : class   -- means reference type
        // where T: struct   -- means value type
        public class User
        {
            public string UserName { get; set; }
            public int Age { get; set; }
            public Address Address { get; set; }

            public User(string username, int age, Address address)
            {
                UserName = username;
                Age = age;
                Address = address;
            }
            public string GetInfo()
            {
                return $"{UserName} ({Age})";
            }
        }

        public struct Address
        {
            public string Street { get; set; }
            public int Number { get; set; }

            public Address(string street, int number)
            {
                Street = street;
                Number = number;
            }

            public string GetFullAddress()
            {
                return $"{Street} No. {Number}";
            }
         
        }
        static void Main(string[] args)
        {
            //boxing
            int number = 9000;
            object obj = number;

            object obj2 = 100;

            object obj3 = 10;
            int number2 = (int)obj3;

            var list = new ArrayList();
            list.Add(100);
            list.Add(false);
            


            Address address = new Address("Bob Street", 11);
            User bob = new User("BobBest", 21, address);
            Console.WriteLine(bob.GetInfo());
            Console.WriteLine(address.GetFullAddress());

            Address newAdress = address;
            newAdress.Number = 50;
            newAdress.Street = "New Street";

            User bobTwin = bob;
            bobTwin.UserName = "BobSuper";
            bobTwin.Age = 45;

            Console.WriteLine("---- after changes ----");
            Console.WriteLine(bob.GetInfo());
            Console.WriteLine(address.GetFullAddress());

            Console.ReadLine();
        }
    }
}
