// Takes user inputted string and outputs it in reverse without using Array.Reverse.

using System;

namespace ReverseStringArray
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a word or sentence:");
			string str = Console.ReadLine();
			char[] ch = str.ToCharArray();
			for (int i = str.Length - 1; i >= 0; i--)
			{
				Console.Write(ch[i]);
			}
		}
	}
}