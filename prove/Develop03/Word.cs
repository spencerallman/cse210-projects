public class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string Display()
{
    if (_isHidden)
    {
        return new string('_', _word.Length);
    }
    else
    {
        return _word;
    }
}

}