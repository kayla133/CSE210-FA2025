//Creativity: I gave the user the capability to add a priority level. They can choose between High, Medium, and Low. I also added a quote about goals that displays when the user quits the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        string runCode = "yes";

        int userChoice = 1;


        while (runCode == "yes")
        {
            manager.DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menue: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
              manager.CreateGoal();
            }
            else if (userChoice == 2)
            {
              manager.ListGoalDetails();
            }
            else if (userChoice == 3)
            {
               manager.SaveGoals();
            }
            else if (userChoice == 4)
            {
                manager.LoadGoals();
            }
            else if (userChoice == 5)
            {
                manager.RecordEvent();
            }
            else if (userChoice == 6)
            {
                Console.WriteLine("Remeber, 'If you can dream it, you can do it.' -Walt Disney");
                runCode = "no";
            }
        }
    }
}