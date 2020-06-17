using SEDC.Adv.Class07.Domain;
using SEDC.Adv.Class07.Domain.Entities;
using SEDC.Adv.Class07.Domain.ListHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv.Class07.AdvLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // get all rekords that first name is Bob
            // SQL syntax
            IEnumerable<Student> findBob = from user in Database.Students
                                              where user.FirstName == "Bob"
                                              select user;

            //findBob.ToList().PrintEntities();

            // Method syntax
            IEnumerable<Student> findBobMethodSyntax = Database.Students.Where(student => student.FirstName == "Bob");
            //findBobMethodSyntax.ToList().PrintEntities();

            // Method syntac with Func< >
            Func<Student, bool> findBobFnc = student => student.FirstName == "Bob";
            IEnumerable<Student> findBobWithFunk = Database.Students.Where(findBobFnc);
            //findBobWithFunk.ToList().PrintEntities();

            // Get part time student that are on academy for programing
            // Query syntax
            var query = from student in Database.Students
                        where student.IsPartTime
                        where (from subject in student.Subjects
                               where subject.Type == Academy.Programming
                               select subject).ToList().Count != 0
                        select student;

            //query.ToList().PrintEntities();

            // Method syntax
            var queryMethodSyntax = Database.Students
                .Where(student => student.IsPartTime)
                .Where(student => student.Subjects
                    .Where(subject => subject.Type == Academy.Programming)
                    .ToList().Count != 0)
                .ToList();

            //queryMethodSyntax.ToList().PrintEntities();

            // students query
            var testQuery = Database.Students
                .Where(student => student.IsPartTime && student.Subjects
                        .Where(subject => subject.Type == Academy.Programming)
                        .ToList().Count != 0)
                .ToList();
            //testQuery.ToList().PrintEntities();

            // third way :)
            var thirdWay = Database.Students
                .Where(student => student.IsPartTime && student.Subjects
                        .Count(subject => subject.Type == Academy.Programming) != 0)
                .ToList();

            //thirdWay.ToList().PrintEntities();

            // First
            var firstRekord = Database.Students.First();
            // var firstRekord1 = Database.Students.First(student => student.FirstName == "z");

            // FirstOrDefault
            var firstOrDefaultRekord = Database.Students.FirstOrDefault();
            var firstOrDefaultRekord1 = Database.Students.FirstOrDefault(student => student.FirstName == "z");

            // Single
            // var singleRekord = Database.Students.Single();
            var singleRekord1 = Database.Students.Single(x => x.FirstName == "Trajan");

            // SingleOrDefault
            // var singleOrDefaultRekord = Database.Students.SingleOrDefault();
            var singleOrDefaultRekord1 = Database.Students.SingleOrDefault(x => x.FirstName == "Trajan");

            // Last
            var lastRekord = Database.Students.Last();
            var lastRekord1 = Database.Students.Last(x => x.FirstName == "Tosho");

            // LastOrDefault
            var lastOrDefaultRekord = Database.Students.LastOrDefault();
            var lastOrDefaultRekord1 = Database.Students.LastOrDefault(x => x.FirstName == "z");

            // check if collection contain elements
            bool result = Database.Students.Any(student => student.FirstName == "Bob");
            bool result1 = Database.Students.Any(student => student.FirstName == "Dwayne");

            if (Database.Students.Any(x => x.IsPartTime))
            {
                Console.WriteLine("Im in if");
            }

            bool result2 = Database.Students.All(x => x.FirstName.Length >= 3);
            bool result3 = Database.Students.All(x => x.FirstName.Length == 4);

            Console.ReadLine();
        }
    }
}
