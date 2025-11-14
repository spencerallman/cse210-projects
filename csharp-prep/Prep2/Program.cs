using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.StartMessage();
                    breathing.InputDuration();
                    breathing.BreathCycle();
                    breathing.EndMessage();
                    break;
                
                case "2":
                    //do something
                    break;
                
                case "3":
                    //do something
                    break;
                
                case "4":
                    running = false;
                    break;
                
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}