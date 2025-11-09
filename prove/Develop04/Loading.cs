public class Loading
{
    private string _title;

    private string _desc;

    private int _duration;

    public Loading(string titleP, string descP)
    {
        _title = titleP;
        _desc = descP;
        _duration = 0;
    }
    Spinner spinner = new Spinner();

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} Activity");
        Console.WriteLine($"{_desc}");
    }

    protected int GetUserDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?: ");
        int seconds;

        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds <= 0)
        {
            Console.Write("Please enter a valid number greater than 0: ");
        }

        _duration = seconds;
        return _duration;

    }

    protected void DisplayGetReady()
    {
        Console.Clear();

        Console.WriteLine("Get ready...");

        //use the spinner function
        spinner.DisplaySpinner(5);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.Write("Well Done!");
        Console.WriteLine();
        
        spinner.DisplaySpinner(5);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");
        spinner.DisplaySpinner();

        Console.Clear();


    }
}