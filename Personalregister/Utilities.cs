﻿using System;
namespace Personalregister
{
	public class Utilities
	{
		static (string Name, decimal Salary)[] workers = new (string, decimal)[100];
		static int workerCount = 0;

		public void DefaultConsoleColor()
		{
			Console.ForegroundColor = ConsoleColor.White;
		}
		public void AddWorker()
		{
			if (workerCount >= workers.Length)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Maximum number of workers reached.");
				DefaultConsoleColor();
				return;
			}

			
			Console.Write("Enter worker's name: ");
			string name = Console.ReadLine();

			Console.Write("Enter worker's salary: ");
		

			if (decimal.TryParse(Console.ReadLine(), out decimal salary))
			{
				workers[workerCount] = (name, salary);
				workerCount++;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Worker added successfully!");
				DefaultConsoleColor();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Invalid salary input, please try again.");
				DefaultConsoleColor();
			}
		}


		public void DisplayWorkers()
		{
			if (workerCount == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("No workers to display.");
				DefaultConsoleColor();
				return;
			}


			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("List of workers:");
			for (int i = 0; i < workerCount; i++)
			{
				Console.WriteLine($"Name: {workers[i].Name}, Salary: {workers[i].Salary} SEK");
			}

			DefaultConsoleColor();
		}
	}
}

