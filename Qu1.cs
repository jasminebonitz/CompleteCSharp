// Receives user input and displays it.

using System;

namespace Qu1
{
	public class Program
	{
		public static void Main()
		{
			string name, city, street;
			int houseNum, zip;

			Console.WriteLine("Bitte geben Sie Ihren Namen ein.");
			name = Console.ReadLine();

			Console.WriteLine("\nBitte geben Sie Ihren Wohnort ein.");
			city = Console.ReadLine();

			Console.WriteLine("\nBitte geben Sie Ihren Straßennamen ein.");
			street = Console.ReadLine();

			Console.WriteLine("\nBitte geben Sie Ihre Hausnummer ein.");
			houseNum = Int32.Parse(Console.ReadLine());

			Console.WriteLine("\nBitte geben Sie Ihre Postleitzahl ein.");
			zip = Int32.Parse(Console.ReadLine());

			Console.WriteLine("\n------------------\n");
			Console.WriteLine("Ihre Addresse:\n");
			Console.WriteLine("Name : {0}\n", name);
			Console.WriteLine("Straße/Hausnummer : {0} {1}\n", street, houseNum);
			Console.WriteLine("Postleitzahl/Stadt : {0} {1}\n", zip, city);
		}
	}
}