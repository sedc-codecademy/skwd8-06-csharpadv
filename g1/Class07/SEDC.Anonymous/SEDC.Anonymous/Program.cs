using SEDC.Anonymous.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Anonymous
{
    class Program
    {
        public static List<string> Names { get; set; } = new List<string>
        {
            "Bob",
            "Jill",
            "Wayne",
            "Greg",
            "John",
            "Anne"
        };

        static void Main(string[] args)
        {
            // Using LINQ.
            Func<string, bool> isAnneFoundAnon = (name) => name == "Anne";
            Func<string, bool> isAnnefoundMethod = CheckForAnne;

            string resultLinqAnonFunc = Names.FirstOrDefault(isAnneFoundAnon);
            string resultLinqMethodFunc = Names.FirstOrDefault(CheckForAnne);


            // Using our custom FindOrDefault extension method.
            string resultAnon = Names.FindOrDefault(name => name == "Anne");
            string resultMethod = Names.FindOrDefault(CheckForAnne);


            // Output.

            Console.WriteLine($"{ resultLinqAnonFunc }");
            Console.WriteLine($"{ resultLinqMethodFunc }");
            Console.WriteLine($"{ resultAnon }");
            Console.WriteLine($"{ resultMethod }");
        }

        public static bool CheckForAnne(string name)
        {
            return name == "Anne";
        }
    }
}
