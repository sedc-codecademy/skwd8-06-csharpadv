using Adv._05.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adv._05.LINQ
{
	class Program
	{
		static void Main(string[] args)
		{
            // LINQ

            // WHERE
            // SQL Like
            Console.WriteLine("WHERE");
            IEnumerable<Student> findBobsSql = from x in SEDC.Students
                                                    where x.FirstName == "Bob"
                                                    select x;
            findBobsSql.ToList().PrintEntities();
            // Lambda
            IEnumerable<Student> findBobsLambda = SEDC.Students
                .Where(x => x.FirstName == "Bob");
            findBobsLambda.ToList().PrintEntities();

            // SELECT
            // SQL Like
            Console.WriteLine("SELECT");
            List<string> firstNamesSql = (from x in SEDC.Students
                                         select x.FirstName).ToList();
            List<string> studentFullNamesSql = (from x in SEDC.Students
                                          select $"{x.FirstName} {x.LastName}").ToList();
            firstNamesSql.PrintSimple();
            studentFullNamesSql.PrintSimple();
            
            // Lambda
            List<string> firstNamesLambda = SEDC.Students.Select(x => x.FirstName).ToList();
            List<string> studentFullNamesLambda = SEDC.Students.Select(x => $"{x.FirstName} {x.LastName}").ToList();
            firstNamesLambda.PrintSimple();
            studentFullNamesLambda.PrintSimple();

            // SQL Like complex example
            Console.WriteLine("COMLEX QUERIES");
            List<Student> ptProgrSqlQuery = (from x in SEDC.Students
                                                   where x.IsPartTime
                                                   where (from y in x.Subjects
                                                          where y.Type == Academy.Programming
                                                          select y).ToList().Count != 0
                                                   select x).ToList();
            ptProgrSqlQuery.PrintEntities();
            // Lambda complex example
            List<Student> ptProgrLambdaQuery = SEDC.Students.Where(x => x.IsPartTime)
                .Where(x => x.Subjects
                    .Where(y => y.Type == Academy.Programming)
                .ToList().Count != 0)
                .ToList();
            ptProgrLambdaQuery.PrintEntities();


            // FIRST / SINGLE / LAST / ORDEFAULT
            // First => Gets first element, if no elements it will throw error
            // FirstOrDefault => Gets first element, if no elements will return default and will not throw error
            // Last => Gets last element, if no elements it will throw error
            // LastOrDefault => Gets last element, if no elements will return default and will not throw error
            // Single => Gets the only element from list, if more than one elements or no elements will throw error
            // SingleOrDefault => Gets the only element from the list, if no elements will return default value, if more than one will throw error

            List<string> emptyListOfStrings = new List<string>();
            List<int> emptyListOfNums = new List<int>();
            List<Student> emptyListOfStudents = new List<Student>();
            Console.WriteLine(SEDC.Students.First().Info());
            Console.WriteLine(SEDC.Students.First(x => x.FirstName.StartsWith("J")).Info());
            // Console.WriteLine(SEDC.Students.Single(x => x.Age > 30)); // ERROR since there are multiple results
            // Console.WriteLine(emptyListOfStrings.First()); // ERROR since there is no first item
            Console.WriteLine(emptyListOfStrings.FirstOrDefault());
            Console.WriteLine(emptyListOfNums.FirstOrDefault());
            // Console.WriteLine(emptyListOfStudents.FirstOrDefault().Id); // ERROR since we got null instead of a student

            // SELECT MANY
            // It flatens list of lists
            // Flattening => When we make one list out of multiple lists of the same type

            // Select
            // Issue because it does not give all the results in one list, but creates a list of lists
            List<List<Subject>> partTimeSubjectsSelect = SEDC.Students
                .Where(x => x.IsPartTime)
                .Select(x => x.Subjects).ToList();
            
            // SelectMany
            // Flatens all the lists in to one list
            List<Subject> partTimeSubjectsMany = SEDC.Students
                .Where(x => x.IsPartTime)
                .SelectMany(x => x.Subjects).ToList();
            partTimeSubjectsMany.PrintEntities();

            // USING INDEX
            // The index is called on the List, not on the Linq query
            Subject partTimeSubject = SEDC.Students
               .Where(x => x.IsPartTime)
               .SelectMany(x => x.Subjects).ToList()[0];
            Console.WriteLine(partTimeSubject.Info());

            // DISTINCT
            List<Subject> distinctSubjects = partTimeSubjectsMany.Distinct().ToList();
            distinctSubjects.PrintEntities();
            Console.WriteLine(distinctSubjects.Count);

            // ANY
            bool isBob = SEDC.Students.Any(x => x.FirstName == "Bob");
            bool isDwayne = SEDC.Students.Any(x => x.FirstName == "Dwayne");
            Console.WriteLine(isBob);
            Console.WriteLine(isDwayne);

            // ALL
            bool areThereShortNames = SEDC.Students
                .All(x => x.FirstName.Length >= 3);
            bool areAllFourChar = SEDC.Students
                .All(x => x.FirstName.Length == 4);
            Console.WriteLine(areThereShortNames);
            Console.WriteLine(areAllFourChar);

            // EXCEPT
            List<Student> exceptPartTime = SEDC.Students
                .Except(SEDC.Students.Where(x => x.IsPartTime)).ToList();
            exceptPartTime.PrintEntities();

            // ORDERBY / ORDERBYDESCENDING / THENBY / THENBYDESCENDING
            List<Student> sortedStudents = SEDC.Students
                .OrderBy(x => x.FirstName).ToList();
            List<Student> sortedStudentsDesc = SEDC.Students
                .OrderByDescending(x => x.FirstName).ToList();
            List<Student> sortedStudentsThen = SEDC.Students
                .OrderBy(x => x.FirstName).ThenBy(x => x.Age).ThenBy(x => x.Id).ToList();
            sortedStudents.PrintEntities();
            sortedStudentsDesc.PrintEntities();
            sortedStudentsThen.PrintEntities();
            Console.ReadLine();
        }
	}
}
