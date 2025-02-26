using System;
using System.Reflection;

class Reflection : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;
    private int _intervals;

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
        _intervals = 5;
    }

    public Reflection(int intervals)
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
        _intervals = intervals;
    }

    private void DisplayPrompt()
    {
        //displays the prompt, picks one at random
    }

    private void SetIntervals()
    {
        //sets the interval between questions based on time given. Also sets the amount of questions so everything displays evenly
    }

    private void Display()
    {
        //displays the set number of random questions, to the set interval
    }

    public void Run()
    {
        //packages everything else up so that I just use run in Program
    }
}