using SEDC.Adv10.FileSystemDatabase.Entities;
using System;

namespace SEDC.Adv10.FileSystemDatabase
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
			Console.WriteLine("Hello World!");
		}
	}
}
