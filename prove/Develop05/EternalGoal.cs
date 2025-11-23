class EternalGoal : Goal
{

   
    public EternalGoal(string title, string description, int points, string priority)
        : base(title, description, points, priority)
        {}
    public EternalGoal(string loadData)
        : base(
            loadData.Split(',')[0],
            loadData.Split(',')[1],
            int.Parse(loadData.Split(',')[2]),
            loadData.Split(',')[4]
        )
    {
        
    }
    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {base.GetDetailsString()}";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{_title}, {_description}, {_points}";
    }
}