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

			// COMPLEX QUERY
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
						   // FINAL PRODUCT => List of students that are part time and have at least 1 subject of type programming

			// FIRST/LAST/SINGLE + ORDEFAULT
			// First -> 
			// Returns the first item from the collection
			// If there are multiple results it will still return the first one it finds
			// If there is no items in the collection it thorws an error
			// Last ->
			// Returns the last item from the collection
			// If there are multiple results it will still return the last one it finds
			// If there is no items in the collection it thorws an error
			// Single ->
			// Returns one unique item from the collection
			// If it finds multiple results it throws an error
			// If there is no items in the collection it thorws an error
			// OrDefault ->
			// We can add OrDefault on First/Last/Single
			// If the collection is empty, don't throw an error. Just return the default value for that type
			// Ask the question: Can the collection be empty and still be a valid business scenario. If it can then OrDefault is the right choice
			// ALL OF THESE METHODS RETURN ONE SINGLE RESULT ( NOT A COLLECTION, unlike WHERE and SINGLE which return IEnumerable )
			List<string> emptyListStrings = new List<string>();
			List<int> emptyListOfInts = new List<int>();
			List<Student> emptyListStudents = new List<Student>();

			// First
			// In this scenario first takes the first item from students collecton
			Console.WriteLine("-------FIRST---------");
			Console.WriteLine(SEDC.Students.First().Info());
			// In this scenario we take the first student that is part time
			// Console.WriteLine(SEDC.Students.First(x => x.IsPartTime == true).Info()); // This is the same as the one bellow. Just different approach
			Console.WriteLine(SEDC.Students.First(x => x.IsPartTime).Info());
			// In this scenario we take the first student that is part time but if there is no such student, we return default
			Console.WriteLine(emptyListStudents.FirstOrDefault());
			// In this scenario we don't expect to have an empty collection, but the collection is empty
			// Console.WriteLine(emptyListStudents.First()); // This will break since there are no students in the collection

			// Last
			// In this scenario last takes the last item from students collecton
			Console.WriteLine("-------LAST---------");
			Console.WriteLine(SEDC.Students.Last().Info());
			// In this scenario we take the last student that is part time
			// Console.WriteLine(SEDC.Students.Last(x => x.IsPartTime == true).Info()); // This is the same as the one bellow. Just different approach
			Console.WriteLine(SEDC.Students.Last(x => x.IsPartTime).Info());
			// In this scenario we take the last student that is part time but if there is no such student, we return default
			Console.WriteLine(emptyListStudents.LastOrDefault());
			// In this scenario we don't expect to have an empty collection, but the collection is empty
			// Console.WriteLine(emptyListStudents.Last()); // This will break since there are no students in the collection

			// Single
			// We try and get a single student that is called Bob
			Console.WriteLine("---------SINGLE---------");
			Console.WriteLine(SEDC.Students.Single(x => x.FirstName == "Bob").Info());
			// We try and get a single student that is part time
			// Console.WriteLine(SEDC.Students.Single(x => x.IsPartTime)); // This will break since there are multiple results
			// In this scenario we take a single student that is called "Joe" but if there is no such student, we return default
			Console.WriteLine(emptyListStudents.SingleOrDefault(x => x.FirstName == "Joe"));
			// In this scenario we don't expect to have an empty collection, but the collection is empty
			// Console.WriteLine(emptyListStudents.Single()); // This will break since there are no students in the collection

			// SELECT and SELECT MANY
			// SELECT just replaces the type that it finds in the result as IEnumerable<THE TYPE>
			// It doesn't care if the type is another list or a class or int or string or whatever
			// Find all subject from the students
			// In the case bellow FirstName is of type string
			// IF Select(x => x.FirsName) -> Result will be -> IEnumerable<Type of x.FirstName> -> that translates to -> IEnumerable<string>
			// In the case bellow Subjects is List<Subject> type
			// IF Select(x => x.Subjects) -> Result will be -> IEnumerable<Type of x.Subjects> -> that translates to -> IEnumerable<List<Subject>> 
			// This covers our goal of getting all subjects from part time students but it is hard to work with
			List<List<Subject>> partTimeSubjectsSelect = SEDC.Students
				.Where(x => x.IsPartTime)
				.Select(x => x.Subjects)
				.ToList(); // List<List<Subject>> because select returns IEnumerable of the type seleceted and the type is List<Subject>
			// SELECT -> Take the list of subjects of bob and put it in the result, then take jills list of subjects and put it in the result ( now we have 2 lists in the result ) and so on
			
			// What happens:
			// 1. We go to the students collection - 157 line
			// 2. We filter the students that are part time - 158 line
			// 3. We select all the subjects of the part time students - 159 line
			// 3.1. The subjects are of type List<Subject> - 159 line
			// 3.2. Select needs to return IEnumerable<Something> - 159 line
			// 3.3. That something in our case is the type List<Subject> - 159 line
			// 3.4. By that definition it returns an IEnumerable<List<Subject>> - 159 line
			// 4. We convert that IEnumerable<List<Subject>> to List<List<Subject>> with the ToList() method - 160 line
			// 5. As developers now we are left with a complicated list of lists that we need to use 2 for loops at least to go through it
			// 6. Our head hurts because of this


			// SELECT MANY
			// Select many flattens a collection of collections
			// Flatten in programming means -> It means that it takes all the items from the collections inside of another collection and puts them together
			// It forms one collection of all the items instead of a collection of a collection of items
			// Instead of having List<List<Subject>> we can flaten it to List<Subject>

			Console.WriteLine("-------SELECT MANY------");
			List<Subject> partTimeSubjectsSelectMany = SEDC.Students
				.Where(x => x.IsPartTime)
				.SelectMany(x => x.Subjects).ToList();

			partTimeSubjectsSelectMany.PrintEntities();

			// SELECT MANY: Take bobs subjects put them in the resut, take jill subjects put them together with bob subjects in the same collection...
			// What happens:
			// 1. We go to the students collection - 181 line
			// 2. We filter the students that are part time - 182 line
			// 3. We SelectMany all the subjects of the part time students - 183 line
			// 3.1. The subjects are of type List<Subject> - 183 line
			// 3.2. SelectMany gets all the Subjects out o the List<Subject> and adds them to the result instead of taking the whole list - 183 line
			// 3.3. SelectMany will return in our case a IEnumerable<Subject> - 183 line
			// 4. We convert that IEnumerable<Subject> to List<Subject> with the ToList() method - 184 line
			// 5. As developers we are happy because we can work with a list of subjects. It is easy, one for loop. We already have a method that does that
			// 6. Our head doesn't hurt as much

			// EXAMPLE of list of lists of lists
			List<List<List<int>>> manyLists = new List<List<List<int>>>()
			{
				new List<List<int>>()
				{
					new List<int>(){ 2, 3, 4, 5 }
				},
				new List<List<int>>()
				{
					new List<int>(){ 7, 88, 77, 988 }
				},
				new List<List<int>>()
				{
					new List<int>(){ 10, 20, 30, 50 }
				}
			};

			// Select many goes only one level
			List<List<int>> manyListResultListInts = manyLists.SelectMany(x => x).ToList();
			// We use Select many twice to go 2 levels 
			List<int> manyListResultInts = manyLists.SelectMany(x => x).SelectMany(x => x).ToList();


			Console.ReadLine();
		}
	}
}
