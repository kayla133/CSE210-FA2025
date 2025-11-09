using System;

class Program
{
    static void Main(string[] args)
    {
        string runCode = "yes";

        int userChoice = 1;

        Console.WriteLine("Welcome to the Mindfulness App...");

        while (runCode == "yes")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menue: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                // Breathing Activity 
                Breathing breathingActivity = new Breathing();
                breathingActivity.RunActivity();
            }
            else if (userChoice == 2)
            {
                // Reflecting Activity
                Reflecting reflecting = new Reflecting();
                reflecting.RunReflectingActivity();
            }
            else if (userChoice == 3)
            {
                // Listing Activity
                Listing listing = new Listing();
                listing.RunListingActivity();
            }
            else if (userChoice == 4)
            {
                // Quit
                Console.WriteLine("Have a mindful day!");
                runCode = "no";
            }
        }
    }
}