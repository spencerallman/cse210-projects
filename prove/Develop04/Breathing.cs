public class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {
        
    }

    public void BreathCycle()
    {
        Console.WriteLine("Breathe In...");
        Countdown();
        Console.WriteLine("Breathe Out...");
        Countdown();
        Console.WriteLine("Breathe In...");
        Countdown();
        Console.WriteLine("Breathe Out...");
        Countdown();
        Console.WriteLine("Breathe In...");
        Countdown();
        Console.WriteLine("Breathe Out...");
        Countdown();
    }
}