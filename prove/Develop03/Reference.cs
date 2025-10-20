class Reference
{
    //attributes
    private string _book;
    private int _chapter;
    private int _beginningVerse;
    private int _endVerse;

    //behaviors
    
    public Reference(string userBook, int userChapter, int userFirstVerse)
    {
        _book = userBook;
        _chapter = userChapter;
        _beginningVerse = userFirstVerse;
    }
    public Reference(string userBook, int userChapter, int userFirstVerse, int userMultiVerse)
    {
        _book = userBook;
        _chapter = userChapter;
        _beginningVerse = userFirstVerse;
        _endVerse = userMultiVerse;
    }
}