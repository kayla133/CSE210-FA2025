using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magig number? ");
        string number = Console.ReadLine();
        int magicnumber = int.Parse(number);

        Console.Write("What is your guess? ");
        int guess = Console.ReadLine();

        string result = "";

        if (guess > magicnumber)
        {
            result = "Lower";
        }
        else if (guess < magicnumber)
        {
            result = "Higher";
        }
        else
        {
            result = "You guessed it!";
        }
    }
}

//While Loop
// string response = "yes";

// while (response == "yes")
// {
//     Console.Write("Do you want to continue? ");
//     response = Console.ReadLine();
// }



//alt + shift + f = Automatically indenting code.


//Do-While Loop
// string response;

// do
// {
//     Console.Write("Do you want to continue? ");
//     response = Console.ReadLine();
// } while (response == "yes");


//For Loop
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }


//Foreach Loops
// foreach (string color in colors)
// {
//     Console.WriteLine(color);
// }

//Random Numbers
// Random randomGenerator = new Random();
// int number = randomGenerator.Next(1, 11);
