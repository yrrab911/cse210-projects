using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your final grade? ");
        string grades = Console.ReadLine();

        string letter = ("");

        int grade = int.Parse(grades);

        if (grade >= 90)
        {
            letter = "A";

            if (grade < 93)
            {
                letter = "A-";
            }

            else

            Console.WriteLine($"You got a {letter}!");
        }
        else if (grade >= 80)
        {
            letter = "B";

            if (grade < 83)
            {
                letter = "B-";
            }

            else if (grade >= 87)
            {
                letter = "B+";
            }

            else

            Console.WriteLine($"You got a {letter}!");
        }
        else if (grade >= 70)
        {
            letter = "C";

            if (grade < 73)
            {
                letter = "C-";
            }

            else if (grade >= 77)
            {
                letter = "C+";
            }

            Console.WriteLine($"You got a {letter}!");
        }
        else if (grade >= 60)
        {
            letter = "D";

            if (grade < 63)
            {
                letter = "D-";
            }

            else if (grade >= 67)
            {
                letter = "D+";
            }

            Console.WriteLine($"You got a {letter}");
        }
        else
        {
            Console.WriteLine($"You got a {letter}");
        }

        if (grade >= 70)
        {
            Console.Write("congratulations, you have passed this class!");
        }

        else
        {
            Console.Write("You have not passed this class, I'm sure you will pass next semester!");
        }
    }
}