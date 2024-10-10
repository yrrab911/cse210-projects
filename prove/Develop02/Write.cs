using System;
using System.IO;
using System.Collections.Generic;

public class Write
{
    public List<string> _list = new List<string>
    {
        "Who is your favorite person?",
        "What day of the week is your favorite?",
        "How long did you sleep?",
        "What is your favorite food?",
        "If you could have a super power what would it be?",
    };

    public object _prompt
    {
        get;
        private set;
    }

    public void writeToFile()
    {
        string _dateTime = DateTime.Now.ToShortDateString();
        string _fileName = "myFile.txt";
        using (StreamWriter _showFile = new StreamWriter(_fileName, true))
        {
            Random _random = new Random();
            int _index = _random.Next(0, _list.Count);
            string _prompt = _list[_index];
            Console.WriteLine($"{_prompt} - ");
            string _response = Console.ReadLine();
            _showFile.WriteLine($"{_dateTime} - {_prompt} - {_response}");
        }
    }
}
