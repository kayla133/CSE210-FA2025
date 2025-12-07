public class Setup
{
    protected string _title;
    protected string _description;

    public Setup(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public virtual string GetDetails()
    {
        return $"{_title} ({_description})";
    }

    public string GetName()
    {
        return _title;
    }
}