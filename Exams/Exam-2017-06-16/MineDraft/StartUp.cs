using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
	static void Main(string[] args)
	{
		string input;
		DraftManager draftManager = new DraftManager();

		while ((input = Console.ReadLine()) != "Shutdown")
		{
			string[] commandArgs = input.Split();
			string command = commandArgs[0];
			List<string> arguments = commandArgs.Skip(1).ToList();

			switch (command)
			{
				case "RegisterHarvester":
					Console.WriteLine(draftManager.RegisterHarvester(arguments));
					break;
				case "RegisterProvider":
					Console.WriteLine(draftManager.RegisterProvider(arguments));
					break;
				case "Day":
					Console.WriteLine(draftManager.Day());
					break;
				case "Mode":
					Console.WriteLine(draftManager.Mode(arguments));
					break;
				case "Check":
					Console.WriteLine(draftManager.Check(arguments));
					break;
			}
		}

		Console.WriteLine(draftManager.ShutDown());
	}
}