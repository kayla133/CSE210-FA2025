class Breathing : Loading
{
    private int _userSeconds = 0;


    public Breathing() : base(
        "Breathing",
    @"This activity will help you relax by walking you through breathing in and out slowly. 
    Clear your mind and focus on your breathing"
    )
    { }

    public void RunActivity()
    {
        DisplayStartingMessage();

        _userSeconds = GetUserDuration();

        DisplayGetReady();
        Spinner spinner = new Spinner();
        Countdown countdown = new Countdown();
        spinner.DisplaySpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_userSeconds);

        //while loop to iterate through the different breathing functions.
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            countdown.RunCountdown(5);

            Console.WriteLine();
            Console.Write("Hold...");
            countdown.RunCountdown(5);

            Console.WriteLine();
            Console.Write("Breathe out...");
            countdown.RunCountdown(5);

            Console.WriteLine();
            Console.Write("Hold...");
            countdown.RunCountdown(5);
        }

        DisplayEndingMessage();
    }
}
