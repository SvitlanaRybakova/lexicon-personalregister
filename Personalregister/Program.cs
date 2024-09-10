using System;

class Program
{
    static (string Name, decimal Salary)[] workers = new (string, decimal)[100];
    static int workerCount = 0;

    static void Main(string[] args)
    {
        ShowMenu();
    }

    static void ShowMenu()
    {
        bool isOpen = true;

        while (isOpen)
        {
            Console.WriteLine("----- Company Worker Management Menu -----");
            Console.WriteLine("1. Add Worker");
            Console.WriteLine("2. Display Workers");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddWorker();
                    break;
                case "2":
                    DisplayWorkers();
                    break;
                case "3":
                    isOpen = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddWorker()
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


    static void DisplayWorkers()
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
