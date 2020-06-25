// Displays usage of the get/set property.

using System;

namespace GetSetProperty
{
	public class Animal
	{
		private string sound;
		public string Sound
		{
			get { return sound; }
			set { sound = value; }
		}
	}

	public class Program
	{
		public static void Main()
		{
			var cat = new Animal();
			cat.Sound = "meow";
			Console.WriteLine("The cat says " + cat.Sound + "!");

			var dog = new Animal();
			dog.Sound = "woof";
			Console.WriteLine("The dog says " + dog.Sound + "!");
		}
	}
}