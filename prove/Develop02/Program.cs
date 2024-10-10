using System;
using System.Xml.Linq;

public class Program
{

    static void Main(string[] args)
    {
        int choose = 0;
        while (choose != 5)
        {
            Console.WriteLine("Choose one of the following - \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \n6. Clear memory");
            choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Write write1 = new Write();
                write1.writeToFile();
            }

            if (choose == 2)
            {
                Display display1 = new Display();
                display1.Read();
            }

            if (choose == 3)
            {
                Load load1 = new Load();
                string file = load1.FileName();
                load1.LoadFile(file);
            }

            if (choose == 4)
            {
                Save save1 = new Save();
                Console.WriteLine("Enter the name of the file to save to:");
                string targetFileName = Console.ReadLine();
                save1.SaveToFile(targetFileName);
            }

            if (choose == 5)
            {
                Console.WriteLine("Goodbye");
                break;
            }

            if (choose == 6)
            {
                string fileName = "myFile.txt";
                File.WriteAllText(fileName, string.Empty);
                Console.WriteLine("All entries have been cleared.");
            }
        }
    }

}