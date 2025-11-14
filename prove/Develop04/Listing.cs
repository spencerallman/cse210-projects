using System.Formats.Asn1;

public class Listing : Activity
{
    List<string> _promptList = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    List<string> _answerList;
    public Listing(string name, string description) : base(name, description)
    {
        
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_promptList[random.Next(0,5)]);
        Console.WriteLine("List as many answers as you would like, type 'quit' to end:");

        bool running = true;

        while (running)
        {
            string listItem = Console.ReadLine();
            if (listItem == "quit")
            {
                running = false;
            }
            else
            {
                _answerList.Add(listItem);
            }
        }
        
    }

    public void DisplaySummary()
    {
        Console.WriteLine("Here are all the items you listed:");
        Console.Write(_answerList);
    }
}