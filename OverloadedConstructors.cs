// Demonstrates the usage of a default constructor with 2 overloaded constructors.

using System;

namespace OverloadedConstructors
{
	public class Test
	{
		public Test()
		{
			Console.WriteLine("Default constructor message.");
		}
		public Test(string str)
		{
			Console.Write("\nFirst overloaded constructor says : ");
			Console.WriteLine(str);
		}
		public Test(int num1, int num2)
		{
			int result = num1 + num2;
			Console.WriteLine("\nSecond overloaded constructor : {0} + {1} = {2}", num1, num2, result);
		}
	}

	public class Program
	{
		public static void Main()
		{
			var test1 = new Test();
			var test2 = new Test("Was für ne einfache Übung!");
			var test3 = new Test(23, 77);
		}
	}
}