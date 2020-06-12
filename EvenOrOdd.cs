// Checks whether the input number is even or odd.

using System;

namespace EvenOrOdd
{
	public class Program
	{
		public static void Main()
		{
			int num;

		Start:
			Console.WriteLine("Enter a number.");
			num = Int32.Parse(Console.ReadLine());

			if (num % 2 == 0)
			{
				Console.WriteLine("\n{0} is an even number.", num);
				Console.WriteLine("-----------");
			}
			else
			{
				Console.WriteLine("\n{0} is an odd number.", num);
				Console.WriteLine("-----------");
			}
			goto Start;
		}
	}
}