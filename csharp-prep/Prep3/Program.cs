using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        while (play == "yes")
        {
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);

            int guess = -1;

            int guesses = 0;

            while (magic != guess)
            {
                guesses++;

                
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                
                if (magic <= guess)
                {
                    Console.WriteLine("lower");
                }

                else if (magic >= guess)
                {
                    Console.WriteLine("higher");
                }

                else
                {
                    Console.WriteLine("you got it!");
                }
            }

            Console.WriteLine($"It took you {guesses} guesses!");

            Console.WriteLine("Would you like to play again");
            play = Console.ReadLine();
        }

    }
}