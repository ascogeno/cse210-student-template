using System;

class Program
{
    static void Main(string[] args)
    {
        Random randy = new Random();
        string answer = "";
        Console.WriteLine("Welcome to the number-guessing game! We're currently workshopping a better name for this.");
        do
        {
            int randomNumber = randy.Next(1, 100);
            int guess;
            do
            {
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
            } while (guess != randomNumber);
            Console.WriteLine("You guessed it!");
            Console.WriteLine("Do you want to play again? (y/n)");
            answer = Console.ReadLine();
        } while (answer == "yes");
    }
}