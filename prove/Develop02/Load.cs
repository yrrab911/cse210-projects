using System;

public class Load
{
    public string FileName()
    {
        Console.WriteLine("What is the name of your file?");
        string _fileName = Console.ReadLine();
        return _fileName;
    }

    public void LoadFile(string _file)
    {
        string _sourceFileName = "myFile.txt";

        string[] _lines = System.IO.File.ReadAllLines(_sourceFileName);

        using (StreamWriter _showFile = new StreamWriter(_file, true))
        {
            foreach (string _line in _lines)
            {
                _showFile.WriteLine(_line);
            }
        }
    }
}
