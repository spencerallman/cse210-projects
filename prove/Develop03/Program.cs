using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("Please enter the book of a scripture you would like to memorize:");
            string book = Console.ReadLine();
            Console.WriteLine("Now please enter the chapter:");
            string chapter = Console.ReadLine();
            Console.WriteLine("Now please enter the verse number(s) (ex. 5 or 5-6)");
            string verses = Console.ReadLine();
            Console.WriteLine("Now please enter the text of the verse(s)");
            string scriptureText = Console.ReadLine();

            int verseStart, verseEnd;
            if (verses.Contains("-"))
            {
                string[] parts = verses.Split("-");
                verseStart = int.Parse(parts[0]);
                verseEnd = int.Parse(parts[1]);
            }
            else
            {
                verseStart = int.Parse(verses);
                verseEnd = verseStart;
            }

            Reference reference = new Reference(book, chapter, verseStart, verseEnd);
            Scripture scripture = new Scripture(reference, scriptureText);

            bool memorizing = true;

            while (memorizing)
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    keepRunning = false;
                    break;
                }

                scripture.HideWords();
            }
            
        }
    }
}