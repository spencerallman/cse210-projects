using System;
using System.Collections;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflecting reflecting = new Reflecting("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listing = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

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
                    reflecting.StartMessage();
                    reflecting.InputDuration();
                    reflecting.DisplayPrompt();
                    reflecting.DisplayQuestion();
                    reflecting.EndMessage();
                    break;
                
                case "3":
                    listing.StartMessage();
                    listing.InputDuration();
                    listing.DisplayPrompt();
                    listing.DisplaySummary();
                    listing.EndMessage();
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