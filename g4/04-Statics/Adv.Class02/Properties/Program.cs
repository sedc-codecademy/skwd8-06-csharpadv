using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person weko = new Person();
            weko.SetAge(42);
            weko.SetFirstName("Wekoslav");
            weko.LastName = "Stefanovski";
            Console.WriteLine($"{weko.GetFirstName()} {weko.LastName}");

            weko.SetAge(weko.GetAge() + 1);
            Console.WriteLine(weko.GetAge());

            weko.Age += 1;
            Console.WriteLine(weko.Age);
       }
    }
}
