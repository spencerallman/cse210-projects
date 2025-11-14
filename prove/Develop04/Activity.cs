using System.Globalization;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?");
    }
    public void EndMessage()
    {
        Console.WriteLine("Well Done!");
        Spinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Spinner();
        Console.Clear();
    }
    public void Countdown(int interval = 1000)
    {
        char[] countdownNumbers = {'5', '4', '3', '2', '1'};
        
        foreach (char num in countdownNumbers)
        {
            Console.Write(num);
            Thread.Sleep(interval);
            Console.Write("\b \b");
        }
    }
    public void InputDuration()
    {
        string durationInput = Console.ReadLine();
        int duration = int.Parse(durationInput);
        _duration = duration;
    }
    public void Spinner(int interval = 500)
    {
        char[] spinnerChars = {'|', '/', '-', '\\', '|', '/', '-', '\\'};

        foreach(char c in spinnerChars)
        {
            Console.Write(c);
            Thread.Sleep(interval);
            Console.Write("\b \b");
        }
    }

}