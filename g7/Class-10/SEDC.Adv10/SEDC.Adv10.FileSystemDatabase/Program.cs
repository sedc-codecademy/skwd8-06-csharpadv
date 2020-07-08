using SEDC.Adv10.FileSystemDatabase.Entities;
using System;
using System.Collections.Generic;

namespace SEDC.Adv10.FileSystemDatabase
{
	class Program
	{
		// Here we create 2 instances of Db<T>, one for Students and one for Subjects
		// We use them to manipulate with students and subjects
		// If we decide to add a new entity to the logic, we don't have to do any changes
		// We can just create a new instance of Db<T> with that new entity
		static Db<Student> _studentDb = new Db<Student>(); // Instead of T we use Student here
		static Db<Subject> _subjectDb = new Db<Subject>(); // Instead of T we use Subject here

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
			Console.WriteLine("======= GET ALL =======");
			List<Student> students = _studentDb.GetAll();
			List<Subject> subjects = _subjectDb.GetAll();

			foreach (Student student in students)
			{
				Console.WriteLine(student.Info());
			}
			foreach (Subject subject in subjects)
			{
				Console.WriteLine(subject.Info());
			}

			Console.ReadLine();
			Console.WriteLine("======= GET BY ID =======");
			Console.WriteLine(_studentDb.GetById(1).Info());
			Console.WriteLine(_subjectDb.GetById(4).Info());

			Console.ReadLine();
			Console.WriteLine("======= GET CREATE STUDENT =======");
			Console.WriteLine("First Name:");
			string first = Console.ReadLine();
			Console.WriteLine("Last Name:");
			string last = Console.ReadLine();
			Console.WriteLine("Age:");
			int age = int.Parse(Console.ReadLine());
			Student newStudent = new Student(first, last, age);
			_studentDb.Insert(newStudent);
			Console.WriteLine("Student created!");

			Console.WriteLine("======= GET ALL =======");
			students = _studentDb.GetAll();
			subjects = _subjectDb.GetAll();

			foreach (Student student in students)
			{
				Console.WriteLine(student.Info());
			}
			foreach (Subject subject in subjects)
			{
				Console.WriteLine(subject.Info());
			}

			Console.ReadLine();

			Console.WriteLine("Do you want to clear the DB? ( Y / N )");
			string answer = Console.ReadLine();

			if(answer.ToLower() == "y")
			{
				_studentDb.ClearDb();
				_subjectDb.ClearDb();
				Console.WriteLine("All cleared. Goodbye!");
			} else
			{
				Console.WriteLine("I guess not. Goodbye!");
			}
			Console.ReadLine();
		}
	}
}
