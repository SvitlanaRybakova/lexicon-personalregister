using System;
using Personalregister;

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
        Utilities utilities = new Utilities();

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
                    utilities.AddWorker(ref workerCount, workers);
                    break;
                case "2":
                    utilities.DisplayWorkers(ref workerCount, workers);
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

}
