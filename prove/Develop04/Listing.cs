using System;

class Listing : Activity
{
    private List<string> _promptList;
    private int counter;

    public Listing() : base("Listing Activty")
    {
        _promptList = ["Who are people that you appreciate?",
                        "Who are people that you have helped this week?",
                        "What are personal strengths of yours?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?",
                        "When have you felt God's love recently?",
                        "What is a meaningful lesson you've learned this month?",
                        "Who is someone you can serve today?",
                        "What is something you're grateful for right now?"];
        counter = 0;
    }

    private void DisplayPrompt()
    {
        //displays a random prompt
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random randy = new Random();
        Console.Write($"--- {_promptList[randy.Next(0, _promptList.Count)]} ---\n\n");
        Console.Write("You may begin in:");
        CountDown(5);
    }

    private void CountInput()
    {
        //increments counter and formats console like the demo video
        DateTime durationTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < durationTime)
        {
            Console.Write(">");
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine($"You listed {counter} items!");
    }

    public void Run()
    {
        //packages everything together so I can just call this from Program
        Intro();
        GetReady();
        DisplayPrompt();
        CountInput();
        WellDone();
    }
}