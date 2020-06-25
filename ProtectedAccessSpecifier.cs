// Displays usage of the protected access specifier.

using System;

namespace ProtectedAccessSpecifier
{
	public class TestShape
	{
		protected string shape;
	}

	public class TestColor
	{
		protected string color;
		public void Print()
		{
			Console.WriteLine("\nMy favorite color is {0}.", color);
		}
	}

	public class Program : TestColor
	{
		public static void Main()
		{
			var p = new Program();
			Console.WriteLine("Enter your favorite color:");
			p.color = Console.ReadLine();
			p.Print();

			var h = new TestShape();
			// Console.WriteLine(h.shape); creates an error because of the protection level
		}
	}
}
