using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        string runCode = "yes";

        int userChoice = 1;

        PromptGenerator generator = new PromptGenerator();
        PromptGenerator journal = new PromptGenerator();

        Journal myJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        while (runCode == "yes")
        {
            Console.WriteLine("Please select one of the following ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
            
                string shownPrompt = generator.PickPrompt();
                Console.WriteLine(shownPrompt);

                string entry = journal.UserJournalEntry();

                myJournal.AddEntry(shownPrompt, entry);
            }
            else if (userChoice == 2)
            {
                myJournal.DisplayEntries();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the file name? ");
                Console.WriteLine();
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the file name? ");
                Console.WriteLine();
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Have a great day!");
                runCode = "no";
            }
        }
    }
}