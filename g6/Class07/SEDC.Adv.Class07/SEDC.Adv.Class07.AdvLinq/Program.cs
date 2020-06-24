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
                // Console.WriteLine("Im in if");
            }


            // Check if all collections elements satisfy some condition  
            bool result2 = Database.Students.All(x => x.FirstName.Length >= 3);
            bool result3 = Database.Students.All(x => x.FirstName.Length == 4);

            // Groups elements by property
            IEnumerable<IGrouping<int, Student>> groupedByAge = Database.Students.GroupBy(student => student.Age).OrderBy(x => x.Key);

            //foreach (var item in groupedByAge)
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("Age: " + item.Key);
            //    foreach (var element in item)
            //    {
            //        Console.WriteLine(element.Info());
            //    }
            //}

            var groupBySubjcet = Database.Students.GroupBy(student => student.Subjects.Count).ToList();
            var groupBySomething = Database.Students.GroupBy(student => student.IsPartTime).ToList();

            //foreach (var item in groupBySubjcet)
            //{
            //    Console.WriteLine("--------------------------");
            //    Console.WriteLine("Subcejects count: " + item.Key);
            //    foreach (var element in item)
            //    {
            //        Console.WriteLine(element.Info());
            //        foreach (var subjcet in element.Subjects)
            //        {
            //            Console.WriteLine(subjcet.Info());
            //        }
            //    }
            //}


            // Intersect
            var numList1 = Database.Subjects.Select(subject => subject.Modules);
            var numList2 = Database.Subjects.Select(subject => subject.StudentsAttending);

            // Gets all elements that are contained in both lists
            var intersect = numList1.Intersect(numList2);

            // second way
            var intersect1 = Database
                .Subjects
                .Select(subject => subject.Modules)
                .Intersect(Database
                    .Subjects
                    .Select(subject => subject.StudentsAttending));

            // Gets all unique elements in both lists
            var union = numList1.Union(numList2);

            //foreach (var num in intersect)
            //{
            //    Console.WriteLine(num);
            //}

            List<List<int>> listOfInts = new List<List<int>>()
            {
                new List<int> { 1, 2, 3, 4},
                new List<int> { 11, 22, 33, 444},
                new List<int> { 111, 222, 333, 4444},
                new List<int> { 1111, 2222, 3333, 44444}
            };

            List<int> listOfIntegers = new List<int>();

            foreach (var itemList in listOfInts)
            {
                foreach (var element in itemList)
                {
                    listOfIntegers.Add(element);
                }
            }

            // Flatens list 
            var selectManyIntegers = listOfInts.SelectMany(x => x).ToList();

            List<List<Subject>> studentSubcejts = Database.Students.Select(student => student.Subjects).ToList();
            List<Subject> studentSubjcets1 = Database.Students.SelectMany(student => student.Subjects).ToList();

            //foreach (var subjcet in studentSubjcets1)
            //{
            //    Console.WriteLine(subjcet.Info());
            //}

            var ageAverage = Database.Students.Average(student => student.Age);
            Console.WriteLine(ageAverage);

            var concatedLists = numList1.Concat(numList2);

            // Database.Students.Add(new Student());
            // Database.Students.AddRange(new List<Student> { new Student(), new Student() });

            var studentsPartTime = Database.Students.Count(student => student.IsPartTime);

            var distinctModules = Database.Subjects.Select(subjcet => subjcet.Modules).Distinct();

            // Except
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 3, 4, 6, 7, 8 };

            var exceptList = list1.Except(list2);

            var orderByAge = Database.Students.OrderBy(student => student.Age).ToList();
            var orderByDescByAge = Database.Students.OrderByDescending(s => s.Age).ToList();

            // Paging using take and skip
            var exampleKlass = new ExampleKlass();
            for (int i = 0; i < 3; i++)
            {
                var students = exampleKlass.GetByPageAndPageSize(i, 5);
                Console.WriteLine($"Page: {i + 1}");
                foreach (var strundet in students)
                {
                    Console.WriteLine(strundet.Info());
                }
            }

            var toDictionary = Database.Students.ToDictionary(key => key.Id, value => value);
            var toDictionary1 = Database.Students.ToDictionary(key => key.Id, value => value.FirstName);

            // case all 3 active filters
            var filteredResults = exampleKlass.FilterStudents(true, true, true);

            // case 2 active filters
            var filteredResults1 = exampleKlass.FilterStudents(opt1: true, opt2: false, opt3: true);

            // case none active filter
            var filteredResults2 = exampleKlass.FilterStudents(false, false, false);

            Excersise1.GetWhiteDogs();

            Console.ReadLine();
        }
    }

    public class ExampleKlass
    {
        public List<Student> GetByPageAndPageSize(int page, int pageSize)
        {
            var result = Database.Students.Skip(page * pageSize).Take(pageSize).ToList();
            return result;
        }

        public List<Student> FilterStudents(bool opt1, bool opt2, bool opt3)
        {
            // get all patrtime == opt1
            // get all younger that 25 == opt2
            // name stats with T == opt3
            IEnumerable<Student> students = Database.Students;

            if (opt1)
            {
                students = students.Where(x => x.IsPartTime);
            }

            // some logic ....

            if(opt2)
            {
                students = students.Where(x => x.Age < 25);
            }

            // some logic ...

            if (opt3)
            {
                students = students.Where(x => x.FirstName.StartsWith("T"));
            }

            return students.ToList();
        }
    }
}

