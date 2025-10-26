using System;
using System.IO.Enumeration;
class Journal
{
    // entries: List<entry>
    public List<Entry> entries = new List<Entry>();


    // prompted generator
    PromptGenerator generator = new PromptGenerator();
    PromptGenerator journal = new PromptGenerator();


    public void DisplayEntries()
    {
        Console.WriteLine("Your Journal Entries: ");
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.GetString());
            Console.WriteLine();
        }

    }

    public void AddEntry(Entry fullEntry)
    {
        entries.Add(fullEntry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
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
                // entries.Add(line);
            }


        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }


}