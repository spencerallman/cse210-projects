using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public int _number;
    public string _menu;
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What do you feel you could have done better today?",
        "How did you feel as you went throughout your day?"
    };
    public Random _random = new Random();

    public void AddEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry _newEntry = new Entry
        {
            _prompt = prompt,
            _entry = response,
            _date = DateTime.Now
        };

        _entries.Add(_newEntry);

    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entry}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry
                {
                    _date = DateTime.Parse(parts[0]),
                    _prompt = parts[1],
                    _entry = parts[2]
                });
            }
        }
    }
}