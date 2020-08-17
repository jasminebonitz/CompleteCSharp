// Demonstrates the virtual and override keywords.

using System;

namespace Polymorphism
{
	public class Program
	{
		public static void Main()
		{
			VW test = new VW();
			test.EngineSpecs();
		}
	}
	public class Engine
	{
		public virtual void EngineSpecs()
		{
			string type = "In-Line 4 Cylinder";
			int hp = 158;
			int rpm = 6700;
			Console.WriteLine("Default Type : {0}", type);
			Console.WriteLine("Default HP : {0}", hp);
			Console.WriteLine("Default RPM : {0}\n", rpm);
		}
	}
	public class VW : Engine
	{
		public override void EngineSpecs()
		{
			base.EngineSpecs();
			string type = "1.4L 4 Cylinder";
			int hp = 147;
			int rpm = 5200;
			Console.WriteLine("Overidden Type : {0}", type);
			Console.WriteLine("Overriden HP : {0}", hp);
			Console.WriteLine("Overidden RPM : {0}", rpm);
		}
	}
}