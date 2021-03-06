﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv10.FileSystemDatabase.Entities
{
	public class Subject : BaseEntity
	{
		public string Title { get; set; }
		public Academy Academy { get; set; }
		public int Classes { get; set; }
		public Subject(string title, Academy academy, int classes)
		{
			Title = title;
			Academy = academy;
			Classes = classes;
		}

		public override string Info()
		{
			return $"{Title} from the {Academy} academy lasts for {Classes} classes!";
		}
	}

	public enum Academy
	{
		Code,
		Networks,
		Design
	}
}
