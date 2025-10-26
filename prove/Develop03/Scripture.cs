public class Scripture
{
    private List<Word> _verse;
    private Reference _reference;

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.Display());
        foreach (Word word in _verse)
        {
            Console.Write(word.Display() + ' ');
        }
        Console.WriteLine();
    }
    
    public void HideWords()
    {
        var random = new Random();
        int hidden = 0;
        foreach(Word word in _verse)
        {
            if (word.IsHidden() == false)
            {
                if (random.Next(0, 2) == 1)
                {
                    word.Hide();
                    hidden = hidden + 1;
                }
            }

            if (hidden >= _verse.Count)
            {
                break;
            }
        }
        
    }
}