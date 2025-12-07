class MSave : Setup
{
    private List<string> MPlan = new List<string>();
    public MSave() : base(
       "Save",
   @"Meal Plan Saved!"
   )
    { }
    private void SaveMPlan();
    private void LoadMPlan();
}