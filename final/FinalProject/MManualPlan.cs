class MManualPlan : Setup
{
    private List<string> sun = new List<string> { };
    private List<string> mon = new List<string> { };
    private List<string> tues = new List<string> { };
    private List<string> wed = new List<string> { };
    private List<string> thurs = new List<string> { };
    private List<string> fri = new List<string> { };
    private List<string> sat = new List<string> { };

    private Dictionary<string, List<string>> FullPlan = new Dictionary<string, List<string>>();
    private readonly List<string> MealTimes = new List<string> { "Breakfast", "Lunch", "Dinner" };

    public MManualPlan() : base(
       "Manually Create Meal Plan",
   @"This page will allow you to make a seven day meal plan."
   )
    { }

    private List<string> GetMealsForDay(string day)
    {
        Console.WriteLine($"\n{day}");
        List<string> meals = new List<string>();

        foreach (string mealTime in MealTimes)
        {
            Console.Write($"    {mealTime}: ");
            string input = Console.ReadLine();

            meals.Add(string.IsNullOrWhiteSpace(input) ? "—" : input.Trim());
        }

        return meals;
    }
    public string CreatePlan()
    {
        Console.WriteLine("Please enter your Meals for the appropriate day.");

        sun = GetMealsForDay("Sunday");
        mon = GetMealsForDay("Monday");
        tues = GetMealsForDay("Tuesday");
        wed = GetMealsForDay("Wednesday");
        thurs = GetMealsForDay("Thursday");
        fri = GetMealsForDay("Friday");
        sat = GetMealsForDay("Saturday");

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

        return "Meal plan created sucessfully!";
    }

    public void DisplayPlan()
    {

        foreach (var day in FullPlan)
        {
            Console.WriteLine($" {day.Key.ToUpper()}:");
            List<string> meals = day.Value;

            if (meals.Count >= 3)
            {
                Console.WriteLine($"    {MealTimes[0]}: {meals[0]}");
                Console.WriteLine($"    {MealTimes[1]}: {meals[1]}");
                Console.WriteLine($"    {MealTimes[2]}: {meals[2]}");
            }
        }

    }

}