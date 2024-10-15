using System;
using System.IO;

public class Instance 
{
    public void SaveToFile(string _targetFileName)
    {
        string _sourceFileName = "myFile.txt";

        if (File.Exists(_sourceFileName))
        {
            string[] _lines = File.ReadAllLines(_sourceFileName);
            using (StreamWriter _writer = new StreamWriter(_targetFileName, false))
            {
                foreach (string _line in _lines)
                {
                    _writer.WriteLine(_line);
                }
            }

            Console.WriteLine($"Data has been saved to '{_targetFileName}'.");
        }
        else
        {
            Console.WriteLine($"Source file '{_sourceFileName}' does not exist.");
        }
    }
}
