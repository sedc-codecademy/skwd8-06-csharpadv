using SEDC.Adv.Class13.FileSystemDatabase.Entities;
using System;

namespace SEDC.Adv.Class13.FileSystemDatabase
{
    class Program
    {
        static IDb<Student> _studentDb = new Db<Student>();
        static IDb<Subject> _subjectDb = new Db<Subject>();

        static void Seed()
        {
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
                _subjectDb.Insert(new Subject("Introduction to Servers", Academy.Network, 32));
                _subjectDb.Insert(new Subject("Photoshop", Academy.Design, 60));
            }
        }

        static void Main(string[] args)
        {
            Seed();

            Console.WriteLine("--- TESTS ---");

            var students = _studentDb.GetAll();
            var subjects = _subjectDb.GetAll();

            Console.WriteLine("--- get all ---");
            foreach (var student in students)
            {
                Console.WriteLine(student.Info());
            }

            foreach (var subject in subjects)
            {
                Console.WriteLine(subject.Info());
            }

            Console.WriteLine("--- Get by id ---");

            var student1 = _studentDb.GetById(2);
            var subject1 = _subjectDb.GetById(1);

            Console.WriteLine(student1.Info());
            Console.WriteLine(subject1.Info());

            Console.WriteLine("--- insert record ---");

            var newStudent = new Student("Tosho", "Todorovski", 30);
            var newSubject = new Subject("c# advanced best practices", Academy.Code, 70);

            var studentId = _studentDb.Insert(newStudent);
            var subjcetId = _subjectDb.Insert(newSubject);

            var newStudent1 = _studentDb.GetById(studentId);
            var newSubject1 = _subjectDb.GetById(subjcetId);

            Console.WriteLine(newStudent1.Info());
            Console.WriteLine(newSubject1.Info());

            Console.WriteLine("--- delete record ---");

            _studentDb.Delete(studentId);
            _subjectDb.Delete(subjcetId);

            foreach (var std in _studentDb.GetAll())
            {
                Console.WriteLine(std.Info());
            }

            foreach (var sbj in _subjectDb.GetAll())
            {
                Console.WriteLine(sbj.Info());
            }

            Console.ReadLine();
        }
    }
}
