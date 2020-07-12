// Displays laptop info using inheritance and constants.

using System;

namespace Inheritance
{
	public class Program
	{
		public static void Main()
		{
			Laptop lt = new Laptop();
			lt.Specs(Laptop.alienware, Laptop.price1, Laptop.i5, Laptop.ram8, Laptop.hd500gb);
			lt.Specs(Laptop.dell, Laptop.price2, Laptop.i7, Laptop.ram16, Laptop.hd1tb);
			lt.Specs(Laptop.asus, Laptop.price3, Laptop.i9, Laptop.ram32, Laptop.hd2tb);
		}
	}

	public class LaptopBase
	{
		public const string dell = "Dell G5 15";
		public const string alienware = "Alienware 13";
		public const string asus = "Asus FX503";

		public const string price1 = "$999";
		public const string price2 = "$1265";
		public const string price3 = "$1299";

		public const string i5 = "i5";
		public const string i7 = "i7";
		public const string i9 = "i9";


		public const string ram8 = "8GB";
		public const string ram16 = "16GB";
		public const string ram32 = "32GB";

		public const string hd500gb = "500GB";
		public const string hd1tb = "1TB";
		public const string hd2tb = "2TB";
	}

	public class Laptop : LaptopBase
	{
		public void Specs(string name, string price, string processor, string ram, string hardDrive)
		{
			Console.WriteLine("Name : " + name);
			Console.WriteLine("Price : " + price);
			Console.WriteLine("Processor : " + processor);
			Console.WriteLine("RAM : " + ram);
			Console.WriteLine("Hard Drive : " + hardDrive + "\n");
		}
	}
}