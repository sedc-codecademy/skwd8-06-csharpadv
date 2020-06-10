using Adv.Class03.Exercise.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.Exercise.Entities
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
