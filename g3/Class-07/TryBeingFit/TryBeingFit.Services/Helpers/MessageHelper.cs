using System;
using System.Collections.Generic;
using System.Text;

namespace TryBeingFit.Services.Helpers
{
    public static class MessageHelper
    {
		//Writes the message given in the parameter with the color in the second parameter and resets the console color
		public static void Color(string message, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
