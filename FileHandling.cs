using System;
using System.IO;

namespace FileHandling
{
	public class Program
	{
		public static void Main()
		{
			string path = @"C:\Student\";
			string studentName, studentLocation, fieldOfStudy;
			int studentAge;

			DirectoryInfo dir = new DirectoryInfo(path);
			dir.Create();
			Console.WriteLine(path + "directory successfully created.");

			Console.WriteLine("\nEnter student name:");
			studentName = Console.ReadLine();
			string newPath = path + studentName + ".txt";
			using (FileStream studentFile = new FileStream(newPath, FileMode.Create))
			{
				Console.WriteLine("\n" + studentName + " file is created at " + newPath);
			}

			Console.WriteLine("\nEnter student age:");
			studentAge = Int32.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter student location:");
			studentLocation = Console.ReadLine();
			Console.WriteLine("\nEnter field of study:");
			fieldOfStudy = Console.ReadLine();

			using (StreamWriter addDetails = new StreamWriter(newPath))
			{
				addDetails.WriteLine("\nStudent name : " + studentName);
				addDetails.WriteLine("Age : " + studentAge);
				addDetails.WriteLine("Location : " + studentLocation);
				addDetails.WriteLine("Field of Study : " + fieldOfStudy);
			}
			Console.WriteLine("\nStudent info saved on " + newPath);

			Start:
				Console.WriteLine("\nSelect 1 to view saved file, 2 to view directory details, or any other key to exit.");
				char choice = Console.ReadKey(true).KeyChar;
				switch (choice)
				{
					case '1':
						{
							string data;
							FileStream fsSource = new FileStream(newPath, FileMode.Open, FileAccess.Read);
							using (StreamReader sr = new StreamReader(fsSource))
							{
								data = sr.ReadToEnd();
							}
							Console.WriteLine(data);
							goto Start;
						}
					case '2':
						{
							Console.WriteLine("\nDirectory name : " + dir.Name);
							Console.WriteLine("Path : " + dir.FullName);
							Console.WriteLine("Created on : " + dir.CreationTime);
							Console.WriteLine("Last accessed : " + dir.LastAccessTime);
							goto Start;
						}
					default:
						{
							break;
						}
				}
		}
	}
}