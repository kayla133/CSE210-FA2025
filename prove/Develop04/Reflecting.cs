class Reflecting : Loading
{
    private int _userSeconds = 0;

    private string _userInput = "";
    public Reflecting() : base(
        "Reflecting",
    @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    { }

    public void RunReflectingActivity()
    {
        DisplayStartingMessage();

        _userSeconds = GetUserDuration();

        string start = _userInput;

        DisplayGetReady();
        Spinner spinner = new Spinner();
        Countdown countdown = new Countdown();

        //get generator info
        ReflectingPromptGenerators generator = new ReflectingPromptGenerators();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_userSeconds);

        Console.WriteLine("Consider the follwoing prompt");

        //grab main prompt
        Console.WriteLine($"--- {generator.GetRandomPrompt()} ---");

        Console.Write("When you have something in mind, press enter to continue.");
        start = Console.ReadLine();

        //call countdown function


        if (string.IsNullOrEmpty(start))
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write($"You may begin in: ");
            countdown.RunCountdown(5);
            //while loop to follow the time alotted.

            while (DateTime.Now < endTime)
            {
                Console.WriteLine();
                // grab sub prompt
                Console.Write($"> {generator.GetRandomQuestion()} ");

                // display spinner
                spinner.DisplaySpinner(8);
            }
        }

        DisplayEndingMessage();
    }

}