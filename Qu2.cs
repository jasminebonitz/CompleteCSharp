// Receives user input and displays it.

using System;

namespace Qu2
{
	public class Program
	{
		public static void Main()
		{
			string name, uni;
			int age, year;

			Console.WriteLine("Bitte geben Sie Ihren Namen ein.");
			name = Console.ReadLine();

			Console.WriteLine("\nBitte geben Sie Ihr Alter ein.");
			age = Int32.Parse(Console.ReadLine());

			Console.WriteLine("\nAuf welche Uni gehen Sie?");
			uni = Console.ReadLine();

			Console.WriteLine("\nIn welchem Jahr der Uni sind Sie?");
			year = Int32.Parse(Console.ReadLine());

			Console.WriteLine("\n------------------\n");
			Console.WriteLine("Student/in Informationen:\n");
			Console.WriteLine("Name : {0}\n", name);
			Console.WriteLine("Alter : {0}\n", age);
			Console.WriteLine("Uni : {0}\n", uni);
			Console.WriteLine("Jahr : {0}", year);
		}
	}
}