class Application
{
    string mealRunCode = "yes";
    string workRunCode = "yes";
    int choice = 1;
    public void MealMenu()
    {
        while (mealRunCode == "yes")
        {
            Console.WriteLine("Meal Plan Options:");
            Console.WriteLine("1. Manually Create Plan");
            Console.WriteLine("2. Auto Create Plan");
            Console.WriteLine("3. List Plan");
            Console.WriteLine("4. Save Plan");
            Console.WriteLine("5. Load Plan");
            Console.WriteLine("6. Go to Workout Plan");
            Console.WriteLine("7. Quit");
            Console.Write("What would you like to do?: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {

            }
            else if (choice == 6)
            {
                mealRunCode = "no";
                workRunCode = "yes";
                WorkoutMenu();
            }
            else if (choice == 7)
            {
                mealRunCode = "no";
            }
        }
    }

    public void WorkoutMenu()
    {
        while (workRunCode == "yes")
        {
            Console.WriteLine("Meal Plan Options:");
            Console.WriteLine("1. Manually Create Plan");
            Console.WriteLine("2. Auto Create Plan");
            Console.WriteLine("3. List Plan");
            Console.WriteLine("4. Save Plan");
            Console.WriteLine("5. Load Plan");
            Console.WriteLine("6. Go to Tracker");
            Console.WriteLine("7. Go to Meal Plan");
            Console.WriteLine("8. Quit");
            Console.Write("What would you like to do?: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {

            }
            else if (choice == 6)
            {

            }
            else if (choice == 7)
            {
                workRunCode = "no";
                mealRunCode = "yes";
                MealMenu();
            }
            else if (choice == 8)
            {
                workRunCode = "no";
            }
        }
    }
}