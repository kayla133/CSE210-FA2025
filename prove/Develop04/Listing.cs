class Listing : Loading
{

    private int _userSeconds = 0;

    List<string> responses = new List<string>();

    public Listing() : base(
        "Listing",
    @"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    { }

    public void RunListingActivity()
    {
        DisplayStartingMessage();
        _userSeconds = GetUserDuration();


        Spinner spinner = new Spinner();
        Countdown countdown = new Countdown();
        ReflectingPromptGenerators generator = new ReflectingPromptGenerators();

       

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_userSeconds);

        DisplayGetReady();

        Console.WriteLine("List as many responses you can to the following prompt: ");

        Console.WriteLine($"--- {generator.GetRandomList()} ---");

        Console.Write("You may begin in: ");
        countdown.RunCountdown(5);
        Console.WriteLine();


        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }

        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndingMessage();
            
    }
}