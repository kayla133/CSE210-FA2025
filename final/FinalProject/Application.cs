class Application
{
    string mealRunCode = "yes";
    string workRunCode = "yes";
    public void MealMenu()
    {
        while (mealRunCode == "yes")
        {
            Console.WriteLine("Meal Plan Options:");
            Console.WriteLine("1. Manually Create Plan");
            Console.WriteLine("2. Auto Create Plan");
            Console.WriteLine("3. Save Plan");
            Console.WriteLine("4. Load Plan");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                MManualPlan planner = new MManualPlan();
                string plan = planner.CreatePlan();
                Console.WriteLine(plan);
            }
            else if (choice == 2)
            {
                MAutoPlan planner = new MAutoPlan();
                string plan = planner.Display();
                Console.WriteLine(plan);
            }
            else if (choice == 3)
            {
                MSave saved = new MSave();
                string save = saved.SavePlan();
                Console.WriteLine(save);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Loading and Listing Options:");
                Console.WriteLine("1. Manual Plan");
                Console.WriteLine("2. Automatic Plan");
                Console.WriteLine("Which plan would you like to Load and List?: ");
                int newChoice = int.Parse(Console.ReadLine());

                if (newChoice == 1)
                {
                    MAutoPlan planner = new MAutoPlan();
                    string plan = planner.Display();
                    Console.WriteLine(plan);
                }
                else if (newChoice == 2)
                {
                    MManualPlan planner = new MManualPlan();
                    planner.DisplayPlan();
                }

            }
            else if (choice == 5)
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
            Console.WriteLine("3. Save Plan");
            Console.WriteLine("4. Load Plan");
            Console.WriteLine("5. Go to Tracker");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do?: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                WManualPlan planner = new WManualPlan();
                string plan = planner.CreatePlan();
                Console.WriteLine(plan);
            }
            else if (choice == 2)
            {
                Console.Clear();
                WAutoPlan planner = new WAutoPlan();
                string plan = planner.Display();
                Console.WriteLine(plan);
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
            }
        }
    }
}