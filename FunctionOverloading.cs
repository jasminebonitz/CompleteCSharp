// Demonstrates function overloadingb by using the same method with different parameters.

using System;

namespace FunctionOverloading
{
	public class Program
	{
		public static void Main()
		{
			Program test = new Program();
			test.Convert(int.MaxValue);
			test.Convert(double.MaxValue);
			test.Convert(float.MaxValue);
		}
		public void Convert(int num)
		{
			Console.WriteLine(num.ToString());
		}
		public void Convert(double num)
		{
			Console.WriteLine(num.ToString());
		}
		public void Convert(float num)
		{
			Console.WriteLine(num.ToString());
		}
	}
}