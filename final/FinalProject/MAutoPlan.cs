class MAutoPlan : Setup
{
    //random generator
    private static readonly Random Rng = new Random();
    string mealPlanOutput = "";

    //create list of breakfast foods
    private List<string> bFoods = new List<string>{"Greek yogurt with honey and berries","Scrambled eggs with spinach & cheese","Overnight oats with chia seeds","Avocado toast with cherry tomatoes","Banana protein smoothie","Cottage cheese with pineapple","Oatmeal with walnuts & cinnamon","Breakfast burrito","Whole-grain waffles with peanut butter","Hard-boiled eggs with fruit","Smoothie bowl with granola","Bagel with cream cheese & cucumbers","Egg white omelet with veggies","Peanut butter & banana toast",
};
    //create list of lunch foods
    private List<string> lFoods = new List<string> {"Grilled chicken salad","Turkey & cheese wrap","Quinoa bowl with black beans","Tuna salad with whole-grain crackers","Lentil soup with side salad","Veggie & hummus sandwich","Brown rice with tofu & vegetables","Chicken Caesar salad","Pasta salad with veggies & feta","Chickpea salad bowl","Grilled cheese with tomato soup","Burrito bowl","Turkey chili","Chicken and veggie stir-fry bowl",
};
    //create list of dinner foods
    private List<string> dFoods = new List<string> {"Baked salmon with roasted broccoli","Beef stir fry with bell peppers","Chicken fajitas","Spaghetti with marinara","Grilled pork chops with sweet potatoes","Baked tilapia with garlic green beans","Vegetable curry with rice","Chicken Alfredo","Shrimp tacos with slaw","Meatloaf with mashed potatoes","Stuffed bell peppers","Beef or turkey burgers with side salad","Chicken stir fry with noodles","Vegetable lasagna",
};

    public MAutoPlan() : base(
        "Automatically Create Meal Plan",
    @"This page will automaticlly create a meal plan for 7 days. The plan will include a meal for Breakfast, Lunch, and Dinner."
    )
    { }

    
    //call a random item from each list if it has not already been call
    private string RandomMeal(List<string> list)
    {
        if (list.Count == 0)
        {
            return "No items left";
        }

        int randomIndex = Rng.Next(0, list.Count);

        string selectedItem = list[randomIndex];

        list.RemoveAt(randomIndex);

        return selectedItem;
    }
    
    //display list
    public string Display()
    {

        for (int day = 1; day <= 7; day++)
        {
            string breakfast = RandomMeal(bFoods);
            string lunch = RandomMeal(lFoods);
            string dinner = RandomMeal(dFoods);

            mealPlanOutput += $"Day {day} {Environment.NewLine}";
            mealPlanOutput += $"    Breakfast: {breakfast}{Environment.NewLine}";
            mealPlanOutput += $"    Lunch: {lunch}{Environment.NewLine}";
            mealPlanOutput += $"    Dinner: {dinner}{Environment.NewLine}";
        }
        return mealPlanOutput.ToString();
    }
    

}