public class Scripture
{
    // attributes
    //_wordList: List<word>
    // private string _scriptureVerse;
    // private List<Word> _scriptureList;
    private string _scriptureText;
    private List<Word> _wordList = new List<Word>();

    // this came from ChatGPT and helps in hiding a random word
    private static readonly Random random = new Random();

    // behaviors
    //constructor Verse(string)
    //Display()
    //GetWordCount(): int
    //GetRevealedCount(); int
    //HideWord(int)
    //HideRandomWord()
    public Scripture(string verseText)
    {
        _scriptureText = verseText;

        SetWordList();

    }


    public void SetWordList()
    {
        string[] parts = _scriptureText.Split(" ");

        foreach (string textWord in parts)
        {
            Word newWord = new Word(textWord);

            _wordList.Add(newWord);
        }
    }

    public List<Word> GetWordList()
    {
        return _wordList;
    }

    public void Display()
    {
        foreach (Word word in _wordList)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public int GetWordCount()
    {
        return _wordList.Count;
    }
    
    
    
    
}