using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do?");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            if (choice == "2")
            {
                journal.Display();
            }
            if (choice == "3")
            {
                journal.SaveToFile();
            }
            if (choice == "4")
            {
                journal.LoadFromFile();
            }
            if (choice == "5")
            {
                running = false;
            }
        }
    }
}