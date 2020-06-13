// Displays the users choice of book based on available options.

using System;

namespace LibraryManagement
{
	public class Program
	{
		public static void Main()
		{
			char option;

			Console.WriteLine("What kind of book are you looking for? Choose an option from the list:\n");
			Console.WriteLine("c - Computer Books\nm - Math Books\nh - History Books\ne - English Books\n");
		Start:
			option = Console.ReadKey(true).KeyChar;

			switch (option)
			{
				case 'c':
					Console.WriteLine("Available computer books:\n");
					Console.WriteLine("Eloquent Javascript\nThink Like A Programmer");
					break;
				case 'm':
					Console.WriteLine("Available math books:\n");
					Console.WriteLine("Fun Algebra\nHow To Not Be Wrong\n2 + 2 = ?");
					break;
				case 'h':
					Console.WriteLine("Available history books:\n");
					Console.WriteLine("ERROR : No history books available.");
					break;
				case 'e':
					Console.WriteLine("Available English books:\n");
					Console.WriteLine("Basic English\nEnglish 101\nEnglish Grammar");
					break;
				default:
					Console.WriteLine("Invalid entry. Please try again.\n");
					goto Start;
			}
		}
	}
}