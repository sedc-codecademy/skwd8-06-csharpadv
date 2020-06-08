using SEDC.Adv.Class03.Excersise.Entities.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class03.Excersise.Entities
{
	public class Teacher : User, ITeacher
	{
		public List<string> Subjects { get; set; }

		public void PrintSubjects()
		{
			foreach (string subject in Subjects)
			{
				Console.WriteLine(subject);
			}
		}

		public override void PrintUser()
		{
			Console.WriteLine($"Teacher: {Name} with username {Username} that teaches {Subjects.Count} subjecs");
		}
	}
}
