// Outputs a diamond shape of ascending and descending numbers.

using System;

namespace NestedForLoop2
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

			for (i = 4; i >= 1; i--)
			{
				for (j = i; j <= 4; j++)
				{
					Console.Write(" ");
				}
				for (m = 1; m < i; m++)
				{
					Console.Write(m);
				}
				for (n = i; n >= 1; n--)
				{
					Console.Write(n);
				}
				Console.WriteLine("\n");
			}
		}
	}
}