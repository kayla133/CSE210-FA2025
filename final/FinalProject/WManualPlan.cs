class WManualPlan : Setup
{
    private List<string> sun = new List<string>{};
    private List<string> mon = new List<string>{};
    private List<string> tues = new List<string>{};
    private List<string> wed = new List<string>{};
    private List<string> thurs = new List<string>{};
    private List<string> fri = new List<string>{};
    private List<string> sat = new List<string>{};
    private Dictionary<string, List<string>> FullPlan = new Dictionary<string, List<string>>();

     public WManualPlan() : base(
        "Manually Create Workout Plan",
    @"This page will allow you to make a seven day wourkout plan."
    )
    { }

    private List<string> GetWorkouts(string day)
    {
        Console.WriteLine($"\n{day}");
        Console.Write("     Workouts (separate multiple workouts with commas, e.g., 'Pushups, Situps, Run'): ");

        string input = Console.ReadLine();

        return input
            .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim())
            .ToList();
    }

    public string CreatePlan()
    {
        Console.WriteLine("Please enter your workouts for the appropriate day.");

        sun = GetWorkouts("Sunday");
        mon = GetWorkouts("Monday");
        tues = GetWorkouts("Tuesday");
        wed = GetWorkouts("Wednesday");
        thurs = GetWorkouts("Thursday");
        fri = GetWorkouts("Friday");
        sat = GetWorkouts("Saturday");

        FullPlan = new Dictionary<string, List<string>>
        {
            {"Sunday", sun},
            {"Monday", mon},
            {"Tuesday", tues},
            {"Wednesday", wed},
            {"Thursday", thurs},
            {"Friday", fri},
            {"Saturday", sat}
        };

        Console.WriteLine();

        return "Workout plan created sucessfully!";
    }

    public void DisplayPlan()
    {
        
        foreach (var day in FullPlan)
        {
            Console.WriteLine($" {day.Key.ToUpper()}:");
            
            if (day.Value.Any())
            {
                foreach (string workout in day.Value)
                {
                    Console.WriteLine($"   - {workout}");
                }
            }
            else
            {
                Console.WriteLine("   - Rest Day / No Workouts Scheduled");
            }
        }

    }

}