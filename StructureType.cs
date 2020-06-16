// Demonstrates the struct data type.

using System;

namespace StructureType
{
	struct Employee
	{
		public string employee_name;
		public int employee_salary;
		public int employee_age;
	}

	public class Program
	{
		public static void Main()
		{
			var emp1 = new Employee();
			Console.WriteLine("Enter employee name:");
			emp1.employee_name = Console.ReadLine();
			Console.WriteLine("\nEnter employee salary:");
			emp1.employee_salary = Int32.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter employee age:");
			emp1.employee_age = Int32.Parse(Console.ReadLine());

			Console.WriteLine("----------");
			Console.WriteLine("Employee Info:");
			Console.WriteLine("\nName : {0}", emp1.employee_name);
			Console.WriteLine("\nSalary : {0}", emp1.employee_salary);
			Console.WriteLine("\nAge : {0}", emp1.employee_age);
		}
	}
}