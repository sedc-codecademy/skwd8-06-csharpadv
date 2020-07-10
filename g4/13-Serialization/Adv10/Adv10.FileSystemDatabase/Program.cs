using System;
using System.Collections.Generic;

namespace Adv10.FileSystemDatabase
{
	class Program
	{
		static Db<Student> _studentDb = new Db<Student>();
		static Db<Subject> _subjectDb = new Db<Subject>();

		// Method that insert some initial data in the database
		static void Seed()
		{

			// Check if inserting works
			// If the databases are empty, only then this will insert the initial data
			if (_studentDb.GetAll().Count == 0)
			{
				Console.WriteLine("======= INSERTING STUDENTS =======");
				_studentDb.Insert(new Student("Bob", "Bobsky", 25));
				_studentDb.Insert(new Student("Jill", "Wayne", 29));
				_studentDb.Insert(new Student("Greg", "Gregsky", 36));
			}

			if (_subjectDb.GetAll().Count == 0)
			{
				Console.WriteLine("======= INSERTING SUBJECTS =======");
				_subjectDb.Insert(new Subject("C# Basic", Academy.Code, 40));
				_subjectDb.Insert(new Subject("Introduction to Servers", Academy.Networks, 32));
				_subjectDb.Insert(new Subject("Photoshop", Academy.Design, 60));
			}
		}
		static void Main(string[] args)
		{
			Seed();
			Console.WriteLine("======= TESTING =======");
			// Check if GetAll work
			List<Student> students = _studentDb.GetAll();
			List<Subject> subjects = _subjectDb.GetAll();

			Console.WriteLine("======= GET ALL =======");
			foreach (Student st in students)
			{
				Console.WriteLine(st.Info());
			}
			foreach (Subject sub in subjects)
			{
				Console.WriteLine(sub.Info());
			}

			Console.WriteLine("======= GET BY ID =======");
			// Check if GetById works
			Console.WriteLine(_studentDb.GetById(2).Info());
			Console.WriteLine(_subjectDb.GetById(1).Info());
			Console.ReadLine();

			Console.Clear();
			// Insert student by inputs
			Console.WriteLine("======= CREATE NEW USER =======");
			Console.WriteLine("Enter First Name: ");
			string first = Console.ReadLine();
			Console.WriteLine("Enter Last Name: ");
			string last = Console.ReadLine();
			Console.WriteLine("Enter Age: ");
			int age = int.Parse(Console.ReadLine());
			Student student = new Student(first, last, age);
			_studentDb.Insert(student);
			Console.WriteLine("======= STUDENT CREATED =======");
			Console.ReadLine();

			Console.WriteLine("======= GET ALL AGAIN =======");
			Console.Clear();
			foreach (Student st in _studentDb.GetAll())
			{
				Console.WriteLine(st.Info());
			}
			Console.ReadLine();

			Console.WriteLine("You want to clear both DB? ( y/n )");
			string answer = Console.ReadLine();
			if(answer.ToLower() == "y")
			{
				_studentDb.ClearDb();
				_subjectDb.ClearDb();
			} 
			else
			{
				Console.WriteLine("I guess not. Goodbye!");
			}
			Console.ReadLine();
		}
	}
}
