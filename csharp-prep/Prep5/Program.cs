using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        string squaredString = squared.ToString();
        DisplayResult(name,squaredString);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        //asks the user for their name
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        //asks the user for their favorite number (for phishing purposes, obviously)
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int toBeSquared)
    {
        return toBeSquared*toBeSquared;
    }

    static void DisplayResult(string name, string numberString)
    {
        Console.WriteLine($"{name}, the square of your number is {numberString}");
    }
}