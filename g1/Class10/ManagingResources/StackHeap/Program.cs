using System;
using System.IO;

namespace StackHeap
{
    class Program
    {
        class Person
        {
            public int Id { get; set; }
        }
        static void Main(string[] args)
        {
            int number = 19;
            string text = "some text";
            bool isTrue = true;
            Person person = new Person() { Id = 1 };
            Person person1 = new Person() { Id = 1 };
            Console.WriteLine(person == person1);
            person.Id = 2;
            person.Id = 5;
            CreatePerson();

            var path = "asd";
            var sr = new StreamWriter(path);
            sr.Close();
            sr.Dispose();
            using (sr = new StreamWriter(path))
            {
                // do anything
            }
            // Stack
                // number = 19
                // text = some text
                // isTrue = true
                // person = 2123124192598235
                // person1 = 1241957204976240
                

            // Heap
                // Person -- {Id = 2}
                // Person1 -- {Id =1}
        }
        public static void CreatePerson()
        {
            var person = new Person();
            string name = "asd";
            person.Id = 1;
        }
    }
}
