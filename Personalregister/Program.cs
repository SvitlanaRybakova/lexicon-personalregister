﻿using System;
using Personalregister;

class Program
{
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----- Company Worker Management Menu -----");
            Console.WriteLine("1. Add Worker");
            Console.WriteLine("2. Display Workers");
            Console.WriteLine("3. Exit");
            utilities.DefaultConsoleColor();
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    utilities.AddWorker();
                    break;
                case "2":
                    utilities.DisplayWorkers();
                    break;
                case "3":
                    isOpen = false;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option, please try again.");
                    utilities.DefaultConsoleColor();
                    break;
            }

            Console.WriteLine();
        }
    }

}
