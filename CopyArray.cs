// Displays an array of numbers copied from one array to another without using the copy method.

using System;

namespace CopyArray
{
	public class Program
	{
		public static void Main()
		{
			int[] nums1 = new int[5];
			int[] nums2 = new int[5];
			int i;
			for (i = 0; i < 5; i++)
			{
				Console.WriteLine("Enter a number:");
				nums1[i] = Int32.Parse(Console.ReadLine());
			}
			Console.WriteLine("\nFirst array values:");
			for (i = 0; i < 5; i++)
			{
				Console.Write(nums1[i] + " ");
			}
			Console.WriteLine("\n\nSecond array values (copied):");
			for (i = 0; i < 5; i++)
			{
				nums2[i] = nums1[i];
				Console.Write(nums2[i] + " ");
			}
		}
	}
}