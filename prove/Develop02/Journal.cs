using System;
using System.IO.Enumeration;

class Journal
{
    public List<string> entries = new List<string>();

    public void AddEntry(string entry)
    {
        entries.Add(entry);
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

        Console.WriteLine($"Entries save to {filename}");
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

            Console.WriteLine($"Entries loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    
    public void DisplayEntries()
    {
        Console.WriteLine("Your Journal Entries: ");
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }
    }
}