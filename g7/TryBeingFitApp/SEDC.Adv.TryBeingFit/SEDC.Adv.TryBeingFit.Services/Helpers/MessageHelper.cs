using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services
{
	public static class MessageHelper
	{
		public static void PrintMessage(string errorMsg, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(errorMsg);
			Console.ResetColor();
			Console.ReadLine();
		}
	}
}
