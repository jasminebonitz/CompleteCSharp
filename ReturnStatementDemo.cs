// Returns values from mathematic operations within each class.

using System;

namespace ReturnStatementDemo
{
	public class Addition
	{
		public static int Test(int a, int b)
		{
			return a + b;
		}
	}
	public class Subtraction
	{
		public static int Test(int a, int b)
		{
			return a - b;
		}
	}
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine(Addition.Test(5, 45));
			Console.WriteLine(Subtraction.Test(2, 10));
		}
	}
}