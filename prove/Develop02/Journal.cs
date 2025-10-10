using System.IO.Enumeration;

class Journal
{
    // the following varabile is for test purposes only.
    // will change to the varible that the user chooses.
    // public string testFilename = "testfile.txt";
    // string[] lines = System.IO.File.ReadAllLines(testFilename);

    // foreach (string line in lines)
    // {
    //     string[] parts = line.Split(",");

    //     string firstName = parts[0];
    //     string lastName = parts[1];

    // }
    // ctr x cut
    // alt shift f auto format

    public void WriteToFile()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

}