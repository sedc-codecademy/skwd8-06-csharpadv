using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.ExtensionMethods
{

    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public User(int id, string name)
        {
            Id = id;
            FullName = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            #region Extension methods
            string first = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.";
            string second = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.";
            string third = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.";

            //Console.WriteLine(first.Shorten(6));
            //Console.WriteLine(second.Shorten(6));
            //Console.WriteLine(third.Shorten(6));


            //Console.WriteLine("Today is a very beautiful day and I want to go outside".Shorten(3));


            Console.WriteLine(first.Shorten(6).QuoteString());
            Console.WriteLine(second.Shorten(6).QuoteString());
            Console.WriteLine(third.Shorten(6).QuoteString());


            #endregion


            #region Generic extension methods
            List<string> fruits = new List<string>() { "apple", "orange", "banana" };
            List<int> numbers = new List<int>() { 1, 2, 3, -10, -12, 8, 9, 6 };
            List<User> users = new List<User>()
            {
                new User(1, "Dejan Jovanov"),
                new User(2, "Martin Panovski"),
                new User(1, "Dragan Gelevski")
            };


            Console.WriteLine("List of fruits:");
            fruits.GoThrough();
            
            Console.WriteLine("List of numbers:");
            numbers.GoThrough();

            Console.WriteLine("List of users:");

            //First select the full name and then call the Generic extension method GoThrough()
            //Since it is only aplicable to List<T> but T must be value (primitive) type 
            //And not a reference one like it is User.
            users.Select(x => x.FullName).ToList().GoThrough();





            #endregion

            Console.ReadLine();
        }
    }
}
