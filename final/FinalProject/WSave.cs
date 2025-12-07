class WSave : Setup
{
    private List<string> WPlan = new List<string>();
    public WSave() : base(
       "Save",
   @"Workout Plan Saved!"
   )
    { }
    private void SaveWPlan();
    private void LoadWPlan();
}