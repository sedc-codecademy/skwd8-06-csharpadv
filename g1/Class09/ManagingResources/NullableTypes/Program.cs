using System;

namespace NullableTypes
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
            Person person = new Person();
            Console.WriteLine(person.Id);
            Console.WriteLine(person.Score);
            person.Score = null;
            person.Name = null;
            person.HasPet = null;
            //person.IsEmployed = null;
            person = null;
            //person.Id = null;
        }
    }
}
