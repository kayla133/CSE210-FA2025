using System
using System.IO;

public class SaveFile
{

    public string filename = "";

    public void SaveToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("test");
        }
    }
}