// Displays usage of the private access specifier.

using System;

namespace PrivateAccessSpecifier
{
	public class Employees
	{
		private string[] names = { "Stefan", "Lukas", "Oliver" };
		private void DisplayNames()
		{
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
		}
	}

	public class Program
	{
		private int[] nums = { 2, 36, 24 };
		private void DisplayNums()
		{
			foreach (int num in nums)
			{
				Console.WriteLine(num);
			}
		}
		public static void Main()
		{
			var p = new Program();
			p.DisplayNums();                // Works because it calls a private method within the same class.
			var e = new Employees();
			e.DisplayNames();               // Not accessible because it calls a private method from another class.
		}
	}
}