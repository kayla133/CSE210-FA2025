public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected string _priority;

    public Goal(string title, string description, int points, string priority)
    {
        _title = title;
        _description = description;
        _points = points;
        _priority = priority;
    }

    public abstract int RecordEvent();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return $"{_title} ({_description}) {_priority}";
    }

    public string GetName()
    {
        return _title;
    }

}