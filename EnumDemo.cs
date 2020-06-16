// Displays an instance of enumeration.

using System;

namespace EnumDemo
{
	enum colors
	{
		red,
		yellow,
		green
	}
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("The numeric position of red is " + (int)colors.red);
			Console.WriteLine("The numeric position of yellow is " + (int)colors.yellow);
			Console.WriteLine("The numeric position of green is " + (int)colors.green);
		}
	}
}