using System;
using System.Xml.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int _choose = 0;
        while (_choose != 5)
        {
            Console.WriteLine("Choose one of the following - \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \n6. Clear memory");
            _choose = int.Parse(Console.ReadLine());
            if (_choose == 1)
            {
                Write _write1 = new Write();
                _write1.writeToFile();
            }

            if (_choose == 2)
            {
                Display _display1 = new Display();
                _display1.Read();
            }

            if (_choose == 3)
            {
                Load _load1 = new Load();
                string _file = _load1.FileName();
                _load1.LoadFile(_file);
            }

            if (_choose == 4)
            {
                Save _save1 = new Save();
                Console.WriteLine("Enter the name of the file to save to:");
                string _targetFileName = Console.ReadLine();
                _save1.SaveToFile(_targetFileName);
            }

            if (_choose == 5)
            {
                Console.WriteLine("Goodbye");
                break;
            }

            if (_choose == 6)
            {
                string _fileName = "myFile.txt";
                File.WriteAllText(_fileName, string.Empty);
                Console.WriteLine("All entries have been cleared.");
            }
        }
    }
}
