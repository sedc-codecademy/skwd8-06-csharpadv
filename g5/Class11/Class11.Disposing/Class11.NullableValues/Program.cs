using System;

namespace Class11.NullableValues
{
    public class Person
    {
        public int Id { get; set; }
        public int? Score { get; set; }
        public bool IsEmployed { get; set; }
        public bool? HasPet { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person prs = new Person();
            // prs.Id = null;
            Console.WriteLine(prs.Id);
            Console.WriteLine(prs.IsEmployed);
            Console.WriteLine(prs.Score);
            Console.WriteLine(prs.Name == null);
            Console.ReadLine();
        }
    }
}
