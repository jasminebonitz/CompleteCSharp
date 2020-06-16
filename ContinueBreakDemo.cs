// Demostrates continue/break usage.

using System;

namespace BreakContinueDemo
{
	public class Program
	{
		public static void Main()
		{
			for (int i = 0; i <= 20; i++)
			{
				if (i == 0)             // Skips 0 and continues the executing the loop.
				{
					continue;
				}
				else if (i == 11)       // Stops iterating through the loop when it reaches 11.
				{
					break;
				}
				Console.WriteLine(i);
			}
		}
	}
}