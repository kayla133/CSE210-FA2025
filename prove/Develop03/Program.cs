using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Console.WriteLine("Hello Develop03 World!");
        Word word1 = new Word("Lehi");
        Word word2 = new Word("dwelt");
        Word word3 = new Word("in");
        Word word4 = new Word("a");
        Word word5 = new Word("tent.");
        word1.Display();
        word2.Display();
        word2.Hide();
        word1.Display();
    }
}