// Shows the difference between checked and unchecked statements.

using System;

namespace CheckedVSUnchecked
{
	public class OverflowTest
	{
		static int maxInt = int.MaxValue;
		int num1, num2;

		public static int CheckedMethod()               // Exception occurs because num1 is out of int range.
		{
			int num1 = 0;
			try
			{
				num1 = checked(maxInt + 10);
			}
			catch (Exception e)
			{
				Console.WriteLine("Caught : " + e.ToString());
			}
			return num1;
		}
		public static int UncheckedMethod()             // Returns false number because it's unchecked
		{                                               // and therefore doesn't flag an exception
			int num1 = 0;
			try
			{
				num1 = unchecked(maxInt + 10);
			}
			catch (Exception e)
			{
				Console.WriteLine("Caught : " + e.ToString());
			}
			return num1;
		}
	}

	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("\nChecked value : {0}", OverflowTest.CheckedMethod());
			Console.WriteLine("Unchecked value : {0}", OverflowTest.UncheckedMethod());
		}
	}
}