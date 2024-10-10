using System;

public class Display
{

    public void Read()
    {
        string fileName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }


}