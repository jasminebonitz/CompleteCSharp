// Calulates the area of a circle (πr^2) and returns the result.

using System;

namespace AreaOfACircle
{
	public class Program
	{
		public static void Main()
		{
			double r, result;
			double pi = Math.PI;

			Console.WriteLine("Enter a radius (cm).");
			r = Int32.Parse(Console.ReadLine());

			result = pi * r * r;

			Console.WriteLine("\nThe area of a circle with the given radius is {0}cm.", result);
		}
	}
}