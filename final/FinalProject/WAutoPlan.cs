class WAutoPlan : Setup
{
    //random generator
    private static readonly Random Rng = new Random();
    string workoutPlanOutput = "";

    //create list of breakfast foods
    private List<string> mon = new List<string>{"Squats", "Push-ups", "Glute Bridges", "Plank", "Reverse Lunges", "Pike Push-ups", "Hip Hinges", "Hollow Hold","Step-ups", "Diamond Push-ups", "Calf Raises", "Side Plank"
    };
    //create list of lunch foods
    private List<string> tues = new List<string> {"Push-ups", "Tricep Dips", "Shoulder Taps", "Superman Hold","Incline Push-ups", "Plank Up-Downs", "Rear Delt Squeezes", "Wide Push-ups","Decline Push-ups", "Arm Circles", "Slow Negative Push-ups", "Forearm Plank"
    };

    //create list of dinner foods
    private List<string> thur = new List<string> {"Squats", "Walking Lunges", "Glute Bridges", "Wall Sit","Bulgarian Split Squats", "Sumo Squats", "Single-Leg RDLs", "Calf Raises","Static Lunges", "Squat Pulses", "Hamstring Walkouts", "Glute Bridge March"
    };


    private List<string> fri = new List<string> {"High Knees", "Squat Jumps", "Mountain Climbers", "Burpees","Step-ups", "Plank Jacks", "Skater Hops", "Jumping Lunges", "Butt Kickers", "Power Knees", "Quick Feet", "Tuck Jumps"
    };

    private List<string> sat = new List<string> {"Cat-Cow", "Child’s Pose", "Down Dog–Plank Flow", "Forward Fold","Hip Flexor Stretch", "Pigeon Pose", "Hamstring Stretch", "Ankle Mobility","Thread-the-Needle", "Chest Stretch", "Neck Circles", "Shoulder Pass-Throughs"
    };




    public WAutoPlan() : base(
        "Automatically Create Workout Plan",
    @"This page will automaticlly create a workout plan for 7 days. The plan will include 5 workout days (with 4 different exercies) and 2 rest days."
    )
    { }


    //call a random item from each list if it has not already been call
    private string RandomWorkout(List<string> list)
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
            string monday = RandomWorkout(mon);
            string tuesday = RandomWorkout(tues);
            string thursday = RandomWorkout(thur);
            string friday = RandomWorkout(fri);
            string saturday = RandomWorkout(sat);

            workoutPlanOutput += $"Day {day} {Environment.NewLine}";
            workoutPlanOutput += $"    Monday: {mon}{Environment.NewLine}";
            workoutPlanOutput += $"    Tuesday: {tues}{Environment.NewLine}";
            Console.WriteLine("     Wednesday: REST");
            workoutPlanOutput += $"    Thurdsay: {thur}{Environment.NewLine}";
            workoutPlanOutput += $"    Friday: {fri}{Environment.NewLine}";
            workoutPlanOutput += $"    Riday: {sat}{Environment.NewLine}";
            Console.WriteLine("     Sunday: REST");
        }
        return workoutPlanOutput.ToString();
    }


}