// Raises an event when certain names are inputted.

using System;

namespace EventHandling
{
	public class Program
	{
		public static void Main()
		{
			UserName uname = new UserName();
			uname.ev_BannedUser += WarningAlarm;
			uname.User();
		}

		static void WarningAlarm(object sender, EventArgs e)
		{
			Console.WriteLine("\nBanned user attempting to log on. Sending E-Mail to administration.");
			Console.WriteLine("Email sent.");
			Console.WriteLine("Warning alarm initiated...");
			Console.WriteLine("Press Ctrl + c to stop the alarm");
			for (; ; )
			{
				Console.Beep();
				System.Threading.Thread.Sleep(100);
			}
		}
	}

	public class UserName
	{
		public event EventHandler<EventArgs> ev_BannedUser;

		public void User()
		{
			Console.WriteLine("Please enter your name:");
			string name = Console.ReadLine();

			if (name == "Jack" || name == "Steven" || name == "Mathew")
			{
				ev_BannedUser(this, new EventArgs(name));
			}
			else
			{
				Console.WriteLine("\nWelcome, {0}.", name);
			}
		}
	}

	public class EventArgs
	{
		public EventArgs(string s)
		{
			Name = s;
		}
		public string Name { get; set; }
	}
}