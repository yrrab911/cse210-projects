using System;

public class Display
{
    public void Read()
    {
        string _fileName = "myFile.txt";
        string[] _lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string _line in _lines)
        {
            Console.WriteLine(_line);
        }
    }
}
