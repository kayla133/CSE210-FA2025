public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string title, string description, int points, string priority)
        : base(title, description, points, priority)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return _points;
        }
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[x]" : "[ ]";
        return $"{status} {base.GetDetailsString()}";
    }

    public SimpleGoal(string loadData)
    : this(
        loadData.Split(',')[0],
        loadData.Split(',')[1],
        int.Parse(loadData.Split(',')[2]),
        loadData.Split(',')[4]
      )
    {
        _isComplete = bool.Parse(loadData.Split(',')[3]);
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_title}, {_description}, {_points}, {_isComplete}, {_priority}";
    }
}