using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string stretch = "";

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is; {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congrats! You passed the course!");
        }
        else
        {
            Console.WriteLine("You have failed the course.");
        }


        if (percentage >= 90)
        {
            Console.WriteLine($"Your final grade is: {grade}");
        }
        else if (percentage < 67)
        {
            Console.WriteLine($"Your final grade is: {grade}");
        }
        else
        {
            int final = percentage / 10;

            if (final >= 7)
            {
                stretch = "+";
            }
            else if (final < 3)
            {
                stretch = "-";
            }

            Console.WriteLine($"Your final grade is: {grade}{stretch}");
        }
    }
}