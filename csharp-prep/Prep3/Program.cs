using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
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
