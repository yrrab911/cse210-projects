using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();

        int usernumber = PromptUserNumber();
        
        int square = SquareNumber(usernumber);

        DisplayResult(username, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squarenumber = number * number;
        return squarenumber;
    }

    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }
}