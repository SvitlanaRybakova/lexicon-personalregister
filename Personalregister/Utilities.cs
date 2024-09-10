using System;
namespace Personalregister
{
	public class Utilities
	{
		public void AddWorker(ref int workerCount, (string Name, decimal Salary)[] workers)
		{
			if (workerCount >= workers.Length)
			{
				Console.WriteLine("Maximum number of workers reached.");
				return;
			}

			Console.Write("Enter worker's name: ");
			string name = Console.ReadLine();

			Console.Write("Enter worker's salary: ");
			if (decimal.TryParse(Console.ReadLine(), out decimal salary))
			{
				workers[workerCount] = (name, salary);
				workerCount++;
				Console.WriteLine("Worker added successfully!");
			}
			else
			{
				Console.WriteLine("Invalid salary input, please try again.");
			}
		}


		public void DisplayWorkers(ref int workerCount, (string Name, decimal Salary)[] workers)
		{
			if (workerCount == 0)
			{
				Console.WriteLine("No workers to display.");
				return;
			}

			Console.WriteLine("List of workers:");
			for (int i = 0; i < workerCount; i++)
			{
				Console.WriteLine($"Name: {workers[i].Name}, Salary: {workers[i].Salary:C}");
			}
		}
	}
}

