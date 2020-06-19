using SEDC.Adv05.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv05.LINQ
{
	class Program
	{
		static void Main(string[] args)
		{
			// LINQ

			// WHERE
			// Filter items from a collection
			// returns IEnumerable<OriginalType> ( OriginalType -> The stored type of the original collection )

			// SQL like syntax 
			IEnumerable<Student> findBobsSql = from x in SEDC.Students
											   where x.FirstName == "Bob"
											   select x;

			// Lambda expression
			IEnumerable < Student > findBobsLambda = SEDC.Students
				.Where(x => x.FirstName == "Bob");

			List<Student> findBobsList = findBobsLambda.ToList();

			// With IEnumerable we lack a lot of features for collections
			//findBobsLambda.Add("New Bob"); // This will not work since it is IEnumreable and IEnumerable does not have Add()
			//Console.WriteLine(findBobsLambda[0]); // This will not work since it is IEnumreable and IEnumerable does not have indexes

			// SELECT
			// Takes a value from the original collection and creates a new collection of that value
			// returns IEnumerable<newValue>

			// Sql like 
			// We wrap the expression in brackets so we can call methods on the result of that expression
			List<string> firstNamesSql = (from x in SEDC.Students
										 select x.FirstName).ToList();
			List<string> fullNamesSql = (from x in SEDC.Students
										 select $"{x.FirstName} {x.LastName}").ToList();
			List<int> exampleWith5sql = (from x in SEDC.Students
									  select 5).ToList();
			Console.WriteLine("SELECT sql like:");
			firstNamesSql.PrintSimple();
			fullNamesSql.PrintSimple();
			exampleWith5sql.PrintSimple();
			// Lambda expression
			// Because LambdaExpression methods can be chained we can use the .ToList() right away
			List<string> firstNamesLambda = SEDC.Students.Select(x => x.FirstName).ToList();
			List<string> fullNamesLambda = SEDC.Students
				.Select(x => $"{x.FirstName} {x.LastName}").ToList();
			List<int> exampleWith5lambda = SEDC.Students.Select(x => 5).ToList();
			Console.WriteLine("SELECT lambda:");
			firstNamesLambda.PrintSimple();
			fullNamesLambda.PrintSimple();
			exampleWith5lambda.PrintSimple();

			// How select works in steps
			// 1. Look at the List and see what type of itmes are there
			// 2. Take the first item and put it in to the variable x
			// 3. Ask for a value 
			// 3.1. FirstName case: We take x.FirstName which is Bob and we add it to the result list
			// 3.2. FullName case: We take x.FirstName + x.LastName and we combine them in one string, so that string is added to the result list ( Bob Bobsky )
			// 3.3. Fives case: We take 5 ( because that is the only thing written there, we ignore x because we never use it )
			// 3.3. Then we put 5 in to the result collection for bob
			// 4. That value will be added as a first item in the result collection
			// 5. Repeat step 2 to 4 for every item in the collection

			// Complex query
			// We need all students that are part time and that have at least 1 subject in programming
			Console.WriteLine("Complex queries sql like:");
			// SQL Like
			List<Student> ptProgrSqlQuery = (from x in SEDC.Students
											 where x.IsPartTime
											 where (from y in x.Subjects
													where y.Type == Academy.Programming
													select y).ToList().Count != 0
											 select x).ToList();

			// Lambda syntax
			List<Student> ptProgrLambda = SEDC.Students // We pick a collection
				.Where(x => x.IsPartTime) // We filter all part time students and Where() returns an IEnumerable<Student>
				.Where(x => x.Subjects // Now we get all subjects of every student
					.Where(y => y.Type == Academy.Programming) // Here we filder those subjects to only subjects from the Programming Academy
					.ToList().Count != 0) // Then we check if there is at least one subject that is from the Programming academy
				.ToList(); // Then we turn the result of part time studnets with at least one subject in Programming Academy to List

			Console.ReadLine();
		}
	}
}
