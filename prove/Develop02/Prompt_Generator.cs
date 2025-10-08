class PromptGenerator
{
    public string promptOne = "Who was the most interesting person I interacted with today?";
    public string promptTwo = "What was the best part of my day?";
    public string promptThree = "How did I see the hand of the Lord in my life today?";
    public string promptFour = "What was the strongest emotion I felt today?";
    public string promptFive = "If I had one thing I could do over today, what would it be?";

    public string shownPrompt = "";

    public string PickPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 5);

        if (number == 1)
        {
            shownPrompt = promptOne;
        }
        else if (number == 2)
        {
            shownPrompt = promptTwo;
        }
        else if (number == 3)
        {
            shownPrompt = promptThree;
        }
        else if (number == 4)
        {
            shownPrompt = promptFour;
        }
        else if (number == 5)
        {
            shownPrompt = promptFive;
        }
        
        return shownPrompt;
    }
}
