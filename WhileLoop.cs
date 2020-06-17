// Returns the result of user given base and exponent values, asks user to continue or not, then loops back if yes.

using System;

namespace WhileLoop
{
	public class Program
	{
		public static void Main()
		{
			double b, e;
			char opt;

		Start:
			Console.WriteLine("Enter a base value:");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("\nEnter an exponent value:");
			e = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("\n{0}^{1} = " + Math.Pow(b, e), b, e);

			Console.WriteLine("\nPress Y to continue or any other key to quit.");
			opt = Convert.ToChar(Console.ReadLine());
			Console.Write("\n");

			while (true)
			{
				if (opt == 'y' || opt == 'Y')
				{
					goto Start;
				}
				else
				{
					Console.Write("Quitting...");
					break;
				}
			}
		}
	}
}