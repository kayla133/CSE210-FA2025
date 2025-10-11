using System;
using System.IO.Enumeration;

class Journal
{
    public List<string> entries = new List<string>();

    public string entry = "";

    PromptGenerator generator = new PromptGenerator();
    PromptGenerator journal = new PromptGenerator();

    public void AddEntry(string prompt, string entry)
    {
        string dateText = DateTime.Now.ToShortDateString();
        string fullEntry = $"Date: {dateText} - Prompt: {prompt}\n{entry}\n";
        entries.Add(fullEntry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }

        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                entries.Add(line);
            }


        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    
    public string DisplayEntries()
    {
        Console.WriteLine("Your Journal Entries: ");
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }

        return entry;
    }
}