using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._05.Domain.Entities
{
	public class Subject : BaseEntity
	{
		public string Title { get; set; }
		public int Modules { get; set; }
		public int StudnetsAttending { get; set; }
		public Academy Type { get; set; }

		public Subject()
		{

		}
		public Subject(int id, string title, int modules, int students, Academy type)
		{
			Id = id;
			Title = title;
			Modules = modules;
			StudnetsAttending = students;
			Type = type;
		}

		public override string Info()
		{
			return $"{Id}) {Title} of the {Type} Academy - {StudnetsAttending} attending!";
		}
	}
	public enum Academy
	{
		Programming,
		Design,
		Networks
	}
}
