class GoalManager
{
    private List<Goal> _goals;
    private int _score;



    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You currently have {_score} points.");
    }

    public void CreateGoal()
    {

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal woud you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("What is the priority level (High, Medium, or Low)?: ");
        string priority = Console.ReadLine();

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points, priority));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points, priority));
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new CheckGoal(name, description, points, target, bonus, priority));
        }
        Console.WriteLine("Goal successully created.");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals currently loaded.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            string details = _goals[i].GetDetailsString();
            Console.WriteLine($"{i + 1}. {details}");
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();

        if (_goals.Count == 0) return;

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            int pointsEarned = selectedGoal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals successfully saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');
            string goalType = parts[0];
            string dataString = parts[1];

            Goal newGoal = null;
            if (goalType == "Simple Goal")
            {
                newGoal = new SimpleGoal(dataString);
            }
            else if (goalType == "Eternal Goal")
            {
                newGoal = new EternalGoal(dataString);
            }
            else if (goalType == "Checklist Goal")
            {
                newGoal = new CheckGoal(dataString);
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal);
            }
        }
        Console.WriteLine("Goals successfully loaded.");
    }

}