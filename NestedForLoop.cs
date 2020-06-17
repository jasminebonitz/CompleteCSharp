// Outputs a triangle of ascending and descending numbers.

using System;

namespace NestedForLoop
{
	public class Program
	{
		public static void Main()
		{
			int i, j, m, n;

			for (i = 1; i <= 5; i++)
			{
				for (j = i; j < 5; j++)
				{
					Console.Write(" ");
				}
				for (m = 1; m < i; m++)
				{
					Console.Write(m);
				}
				for (n = i; n > 0; n--)
				{
					Console.Write(n);
				}
				Console.WriteLine("\n");
			}
		}
	}
}