public class Memorize
{
    // attributes
    // _reference: ScriptureCitation
    // _verses: List<Verse>



    // // behaviors
    // constructor ScriptureToMemorize()
    // constructor ScriptureTo Memorize(Reference, List<Verse>)
    // Display()
    // HideThreeRandomWords()
    private Scripture _scripture;
    private static readonly Random random = new Random();

    public Memorize(Scripture scripture)
    {
        _scripture = scripture;
    }

    public void DisplayScripture()
    {
        _scripture.Display();
    }

    public void HideThreeRandomWords()
    {
        SelectHideWords(_scripture.GetWordList(), 3);
    }

    public bool AllWordsHidden()
    {
        return _scripture.GetWordList().All(word => word.IsHidden());
    }

    private void SelectHideWords(List<Word> wordList, int countToHide)
    {
        // Get words that are still visible
        List<Word> revealedWords = wordList.Where(word => !word.IsHidden()).ToList();

        if (revealedWords.Count == 0)
        {
            return;
        }

        int wordsToHide = Math.Min(countToHide, revealedWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(revealedWords.Count);
            revealedWords[randomIndex].Hide();
            revealedWords.RemoveAt(randomIndex);
        }
    }
}
