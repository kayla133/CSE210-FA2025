using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        string runCode = "yes";

        int userChoice = 1;

        PromptGenerator generator = new PromptGenerator();
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
                Console.WriteLine(generator.PickPrompt());
                Console.Write("> ");
                Console.ReadLine();
            }
            else if (userChoice == 2)
            {

            }
            else if (userChoice == 3)
            {

            }
            else if (userChoice == 4)
            {

            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Have a great day!");
                runCode = "no";
            }
        }
    }
}