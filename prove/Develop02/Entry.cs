class Entry
{

    // ATTRIBUTES
    // _date holds the date when the variable was writted
    public string _dateText = DateTime.Now.ToShortDateString();

    // _prompt that was given to the user
    public string _prompt = "";

    // _hold what the user typed
    public string _entries = new string("");







    // METHOD
    // display
    public string GetString()
    {
        return $"{_dateText} {_prompt} {_entries}";
    }



}