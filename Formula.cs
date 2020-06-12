// Calculates (a+b)^2 and returns the output.

using System;

namespace Formula
{
	public class Program
	{
		public static void Main()
		{
			int a, b, result;

			Console.WriteLine("Enter a number.");
			a = Int32.Parse(Console.ReadLine());

			Console.WriteLine("\nEnter a second number.");
			b = Int32.Parse(Console.ReadLine());

			result = a + b;
			result *= result;

			Console.WriteLine("\n({0}+{1})^2 = {2}", a, b, result);
		}
	}
}