// Displays various math calculations using static methods.

using System;

namespace StaticMethods
{
	public class Calculate
	{
		static int num1, num2, result;
		public static void AcceptNums()
		{
			Console.WriteLine("Enter first number:");
			num1 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter second number:");
			num2 = Int32.Parse(Console.ReadLine());
		}

		public static void Add()
		{
			result = num1 + num2;
			Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
		}
		public static void Subtract()
		{
			result = num1 - num2;
			Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
		}
		public static void Multiply()
		{
			result = num1 * num2;
			Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
		}
		public static void Divide()
		{
			result = num1 / num2;
			Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
		}
	}

	public class Program
	{
		public static void Main()
		{
			Calculate.AcceptNums();
			Calculate.Add();
			Calculate.Subtract();
			Calculate.Multiply();
			Calculate.Divide();
		}
	}
}