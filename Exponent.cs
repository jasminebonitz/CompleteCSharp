// Calculates value based on users base and exponent input.

using System;

namespace Exponent
{
	public class Calc
	{
		public static double Exponent()
		{
			Console.WriteLine("Enter a base value:");
			double b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\nEnter an exponent value:");
			double e = Convert.ToDouble(Console.ReadLine());

			double result = Math.Pow(b, e);
			return result;
		}
	}

	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("\n" + Calc.Exponent());
		}
	}
}