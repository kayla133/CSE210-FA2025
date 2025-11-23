class CheckGoal : Goal
{
    public int _target;
    public int _bonus;
    public int _amountCompleted;
    public CheckGoal(string title, string description, int points, int target, int bonus, string priority)
    : base(title, description, points, priority)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:{_title}, {_description}, {_points}, {_target}, {_bonus}, {_amountCompleted}, {_priority}";
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int pointsEarned = _points;
        if (_amountCompleted == _target)
        {
            pointsEarned += _bonus;
        }

        return pointsEarned;
    }

    public override string GetDetailsString()
    {
        string status = (_amountCompleted == _target) ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()} -- Completed {_amountCompleted}/{_target} times";
    }

    public CheckGoal(string loadData)
        : base(
            loadData.Split(',')[0],
            loadData.Split(',')[1],
            int.Parse(loadData.Split(',')[2]),
            loadData.Split(',')[4]
        )
    {
        string[] parts = loadData.Split(',');

        _target = int.Parse(parts[3]);
        _bonus = int.Parse(parts[4]);
        _amountCompleted = int.Parse(parts[5]);
    }
}