public class Word
{
    // attributes
    private string _word;
    private bool _isHidden;

    // behaviors
    public Word(string userWords)
    {
        _word = userWords;
        _isHidden = false;
    }

    public string GetDisplayText()
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

    public void Hide()
    {
        _isHidden = true;
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }
}