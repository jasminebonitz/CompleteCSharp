// Demonstrates usage of command line arguments.

using System;

namespace CommandLineArgs
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int num1 = Int32.Parse(args[0]);
			int num2 = Int32.Parse(args[1]);
			int parameter = num1 + num1 + num2 + num2;
			int area = num1 * num2;
			Console.WriteLine("The parameter of a rectangle with a width of {0} and length of {1} is {2}", num1, num2, parameter);
			Console.WriteLine("The area of a rectangle with a width of {0} and length of {1} is {2}", num1, num2, area);
		}
	}
}