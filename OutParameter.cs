// Displays the usage of the out parameter.

using System;

namespace OutParameter
{
	public class Program
	{
		public static void Calculate(int num1, int num2, int num3, int num4, out int add, out int subtract, out int multiply)
		{
			add = num1 + num2 + num3 + num4;
			subtract = num1 - num2 - num3 - num4;
			multiply = num1 * num2 * num3 * num4;
		}
		public static void Main()
		{
			int num1, num2, num3, num4, add, subtract, multiply;
			Console.WriteLine("Enter first number:");
			num1 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter second number:");
			num2 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter third number:");
			num3 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter fourth number:");
			num4 = Int32.Parse(Console.ReadLine());

			Program.Calculate(num1, num2, num3, num4, out add, out subtract, out multiply);
			Console.WriteLine("\n{0} + {1} + {2} + {3} = {4}", num1, num2, num3, num4, add);
			Console.WriteLine("\n{0} - {1} - {2} - {3} = {4}", num1, num2, num3, num4, subtract);
			Console.WriteLine("\n{0} * {1} * {2} * {3} = {4}", num1, num2, num3, num4, multiply);
		}
	}
}