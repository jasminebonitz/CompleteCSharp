// Calculates the area of a triangle with the user inputted length and height.

using System;

namespace AreaOfTriangle
{
	public class Program
	{
		public static void Main()
		{
			double length, height, area;

			Console.WriteLine("Enter the length of the triangle (cm).");
			length = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("\nEnter the height of the triangle (cm).");
			height = Convert.ToDouble(Console.ReadLine());

			area = length * height / 2;

			Console.WriteLine("\nThe area of the triangle is {0}cm^2.", area);
		}
	}
}