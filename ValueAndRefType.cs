// Displays the difference between value types and reference types.

using System;

namespace ValueAndRefType
{
	public class Type
	{
		public static void Value(int num)
		{
			num++;
		}

		public static void Reference(ref int num)
		{
			num++;
		}
	}

	public class Program
	{
		public static void Main()
		{
			int num;
			Console.WriteLine("Enter a number:");
			num = Int32.Parse(Console.ReadLine());
			Console.WriteLine("\nVALUE TYPE");
			Console.WriteLine("\nOriginal Value : {0}", num);
			Type.Value(num);                                    // Not affected because it creates a separate copy of the variable.
			Console.WriteLine("\nNew Value : {0}", num);

			Console.WriteLine("\n-----------\n");
			Console.WriteLine("REFERENCE TYPE");
			Console.WriteLine("\nOriginal Value : {0}", num);
			Type.Reference(ref num);                            //Refers to the Type method and reflects accordingly.
			Console.WriteLine("\nNew Value : {0}", num);
		}
	}
}