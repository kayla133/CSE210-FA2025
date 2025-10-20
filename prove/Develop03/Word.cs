class Word
{
    // attributes
    private string _word;
    private bool _revealed;

    // behaviors
    public Word(string userWords)
    {
        _word = userWords;
        _revealed = true;
    }

    public void Display()
    {
        if (_revealed)
        {
            Console.Write(" " + _word);
        }
        else
        {
            Console.Write(" ");
            int length = _word.Length;
            for (int i = 0; i < length; i ++)
            {
                Console.Write("_");
            }
        }
    }

    public void Hide()
    {
        _revealed = false;
    }
    
    public bool IsRevealed()
    {
        return _revealed;
    }
}