using System;

class Program
{
    static void Main(string[] args)
    {
        
        string userChoice = "";

        Reference book = new Reference("Proverbs", 3, 5, 6);

        string verseText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(verseText);
        
        Memorize memorizer = new Memorize(scripture);


        // This loop continues until the user types "quit"
        while (userChoice.ToLower() != "quit" && !memorizer.AllWordsHidden())
        {
            
            
            book.DisplayMulti();
            scripture.Display();
            Console.WriteLine(); 
            Console.Write("Press Enter to hide words or type 'quit' to finish: ");

            
            userChoice = Console.ReadLine();

            if (userChoice.ToLower() != "quit")
            {
                Console.Clear();
                memorizer.HideThreeRandomWords();
            }

            
            if (userChoice.ToLower() == "quit")
            {
                userChoice = "quit";
            }
        
        }
    }
}