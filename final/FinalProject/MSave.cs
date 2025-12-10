class MSave : Setup
{
    private List<string> MPlan = new List<string>();
    public MSave() : base(
       "Save",
   @"Meal Plan Saved!"
   )
    { }
    public string SavePlan()
    {
        Console.Write("What is the filename for the goal file?: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(MPlan.Count);
            foreach (string planItem in MPlan)
            {
                outputFile.WriteLine(planItem);
            }
            return"Meal Plan successfully saved.";
        }       
    }
}
// private void LoadMPlan();
// }