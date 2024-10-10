using System;
using System.IO;

public class Save
{
    public void SaveToFile(string targetFileName)
    {
        string sourceFileName = "myFile.txt";

        if (File.Exists(sourceFileName))
        {
            string[] lines = File.ReadAllLines(sourceFileName);
            using (StreamWriter writer = new StreamWriter(targetFileName, false))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine($"Data has been saved to '{targetFileName}'.");
        }
        else
        {
            Console.WriteLine($"Source file '{sourceFileName}' does not exist.");
        }
    }
}
