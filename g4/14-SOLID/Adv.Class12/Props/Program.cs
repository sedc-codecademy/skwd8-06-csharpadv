using System;
using System.Reflection.Metadata;

namespace Props
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.FirstName = "Wekoslav";

            p.Age = 42;
            p.SetAge2(42);
            p.Age3 = 42;

            // p.LastName = "Stefanovski";
            p.SetLastName("Stefanovski");

            var park = new Parking();
            park.Capacity = 100;
            park.Free = 30;

            Console.WriteLine(park.AreThereFreeSpaces());

            // park.HasFree = false;

            int[] array = Array.Empty<int>();

            Console.WriteLine(array.Length);
            // array.Length = 10;


            // easy and clear
            p.Age += 1;

            // powerful
            p.SetAge2(p.GetAge2() + 1);

            // both clear and powerful
            p.Age3 += 1;

            Console.WriteLine("-------------------------");

            Console.WriteLine("Car parking");
            park.Occupied += 1;
            Console.WriteLine(park.Free);

            Console.WriteLine("Car leaving");
            park.Occupied -= 1;
            Console.WriteLine(park.Free);

        }
    }
}
