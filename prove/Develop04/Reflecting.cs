public class Reflecting : Activity
{
    private List<string> _promptList = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questionList = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    public Reflecting(string name, string description) : base(name, description)
    {
        
    }
    public void DisplayPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_promptList[random.Next(0,4)]);
        Spinner();
    }
    public void DisplayQuestion()
    {
        Random random = new Random();
        Console.WriteLine(_questionList[random.Next(0,9)]);
        Spinner();
        Console.WriteLine(_questionList[random.Next(0,9)]);
        Spinner();
        Console.WriteLine(_questionList[random.Next(0,9)]);
        Spinner();
        Console.WriteLine(_questionList[random.Next(0,9)]);
        Spinner();

    }

}