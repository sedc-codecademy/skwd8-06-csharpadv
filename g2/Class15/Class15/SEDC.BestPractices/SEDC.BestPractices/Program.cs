using System;
using System.Collections.Generic;

namespace SEDC.BestPractices
{
    public class User
    {
        //Use private fields only when necessary, and use the underscore and camel case notation
        private int _id;
        public int Id { get; set; } = 0;
        public string FirstName { get; set; }

        public int IdGenerator()
        {
            _id += 1;
            Id = _id;
            return Id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = String.Empty;
            bool isRaining = false;

            Console.WriteLine("Hello user please enter your name!");
            name = Console.ReadLine();

            //Use invert if check to make your code redundant
            if (!isRaining)
                Console.WriteLine("You can go to the beach!");

        }
    }
}
