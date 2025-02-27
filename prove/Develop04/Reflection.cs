using System;
using System.Reflection;

class Reflection : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;

    public Reflection() : base("Reflection Activty")
    {
        _promptList = ["Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless.",
                        "Think of a time when you had to make a tough decision.",
                        "Think of a time when you worked hard for something and achieved it."];
        _questionList = ["Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times when you were not as successful?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience that applies to other situations?",
                        "What did you learn about yourself through this experience?",
                        "How can you keep this experience in mind in the future?",
                        "How did this experience change your perspective?",
                        "What challenges did you face along the way?",
                        "What skills or qualities did you use to navigate this experience?",
                        "How did this experience impact your relationships with others?"];
    }

    private void DisplayPrompt()
    {
        //displays the prompt, picks one at random. Awaits user input before proceeding
        Console.WriteLine("Consider the following prompt:\n");
        Random randy = new Random();
        Console.Write($"--- {_promptList[randy.Next(0, _promptList.Count)]} ---\n\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            // Do nothing—just wait for Enter
        }
        Console.Clear();
    }

    private void Display()
    {
        //displays the set number of random questions, every 15 seconds until duration is reached
        Random randy = new Random();
        DateTime durationTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < durationTime)
        {
            Console.Write($">{_questionList[randy.Next(0, _questionList.Count)]}");
            Animation(15);
            Console.Write("\n");
        }
        Console.Write("\n");
    }

    public void Run()
    {
        //packages everything else up so that I just use run in Program
        Intro();
        GetReady();
        DisplayPrompt();
        Display();
        WellDone();
    }
}