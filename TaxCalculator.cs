// Calculates the amount of tax for user inputted amount.

using System;

namespace TaxCalculator
{
	public class Program
	{
		public static void Main()
		{
			double money, percentage;
		Start:
			Console.WriteLine("To calculate tax percentage, enter total in dollars.");
			money = Convert.ToDouble(Console.ReadLine());

			if (money > 100000)
			{
				percentage = .085;
			}
			else if (money >= 10000)
			{
				percentage = .08;
			}
			else if (money > 0)
			{
				percentage = .05;
			}
			else
			{
				Console.WriteLine("\nInvalid amount, try again.\n");
				goto Start;
			}
			money = Math.Round(money * percentage, 2);
			Console.WriteLine("\nTax : ${0}", money);
		}
	}
}