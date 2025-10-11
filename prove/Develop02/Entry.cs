public class Entry
{
    public DateTime _date = DateTime.Now;
    public string _entry;
    public string _prompt;

    public void Display()
    {
        string dateText = _date.ToShortDateString();

        Console.WriteLine($"Date: {dateText} - Prompt: {_prompt}");
        Console.WriteLine($"{_entry}");
        Console.WriteLine();
    }
}