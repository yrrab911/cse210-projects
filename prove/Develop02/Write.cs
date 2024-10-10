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

    public object prompt
    {
        get;
        private set;
    }

    public void writeToFile()
    {
        string dateTime = DateTime.Now.ToShortDateString();
        string fileName = "myFile.txt";
        using (StreamWriter showfile = new StreamWriter(fileName, true))
        {
            Random random = new Random();
            int index = random.Next(0, _list.Count);
            string prompt = _list[index];
            Console.WriteLine($"{prompt} - ");
            string response = Console.ReadLine();
            showfile.WriteLine($"{dateTime} - {prompt} - {response}");
        }
    }

}