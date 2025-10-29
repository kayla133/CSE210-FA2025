class Assignment
{
    // attributes
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // methods

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}