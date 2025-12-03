using System;

class Program
{
    static void Main(string[] args)
    {
        string runCode = "yes";
        int userChoice = 1;

        while (runCode == "yes")
        {
            Console.WriteLine("Welcome to the Health Planner!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Enter Meal Plan Application");
            Console.WriteLine("2. Enter Workout Plan Applicaiton");
            Console.WriteLine("3. Quit");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                
            }
            else if (userChoice == 2)
            {
                
            }
            else if (userChoice == 3)
            {
                runCode = "no";
            }

        }
    }
}