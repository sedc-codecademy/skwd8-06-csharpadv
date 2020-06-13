using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person weko = new Person();
            weko.Age = 42;
            weko.FirstName = "Wekoslav";
            weko.LastName = "Stefanovski";
            Console.WriteLine($"{weko.FirstName} {weko.LastName}");
            // Console.WriteLine(weko.FullName);

            //weko.SetAge(weko.GetAge() + 1);
            //Console.WriteLine(weko.GetAge());

            weko.Age += 1;
            Console.WriteLine(weko.Age);


            Console.WriteLine("------------");

            var parking = new Parking();
            parking.Capacity = 100;
            parking.Occupied = 80;

            Console.WriteLine(parking);

            parking.Free = 40;
            Console.WriteLine(parking);

            parking.Capacity = 200;
            Console.WriteLine(parking);

        }
    }
}
