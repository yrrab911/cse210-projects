using System;

public class Load
{

    public string FileName()
    {
        Console.WriteLine("What is the name of your file?");
        string fileName = Console.ReadLine();
        return fileName;
    }

    public void LoadFile(string file)
    {
        string filename = "myFile.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        using (StreamWriter showFile = new StreamWriter(file, true))
        {

            foreach (string line in lines)
            {
                showFile.WriteLine(line);
            }
        }
    }

}