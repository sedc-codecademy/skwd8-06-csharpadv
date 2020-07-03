using System;

namespace SEDC.ClassDispose.HeapAndStack
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Person martin = new Person() { Id = 1, FullName = "Martin Panovski" };
            Person dejan = martin;

            dejan.FullName = "Dejan Jovanov";
            Console.WriteLine(martin.FullName);


            Console.ReadLine();
        }
    }
}
