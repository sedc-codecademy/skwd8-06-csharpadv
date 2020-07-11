using System;

namespace Props
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.FirstName = "Wekoslav";

            p.Age = 100000;

            // p.LastName = "Stefanovski";
            p.SetLastName("Stefanovski");
        }
    }
}
