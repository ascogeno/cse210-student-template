using System;

class Activity
{
    private string _name; //base for welcome messsage, modified as needed by intro function
    protected int _duration; //stores the duration by the user. measured in seconds
    private string _welcome;
    public Activity()
    {
        _name = "_";
        _duration = 30;
    }

    public Activity(string name)
    {
        _name = name;
        _duration = 0;
    }

    protected void GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like your session? ");
        _duration = Int32.Parse(Console.ReadLine());
    }

    protected void Animation(int secs)
    {
        //loops through these characters |\-/
        DateTime futureTime = DateTime.Now.AddSeconds(secs);
        while (DateTime.Now < futureTime)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void CountDown(int secs)
    {
        int time = secs;
        DateTime futureTime = DateTime.Now.AddSeconds(secs);
        while (DateTime.Now < futureTime)
        {
            Console.Write(time);
            time--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write("\n");
    }

    protected void GetReady()
    {
        //displays "Get ready..." before the activities. See demo video
        Console.Clear();
        DateTime futureTime = DateTime.Now.AddSeconds(5);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Get ready...\n");
            Animation(5);
        }
        Console.Write("\n\n");
    }

    protected void WellDone()
    {
        //displays ending message for each activity. See demo video
        DateTime futureTime1 = DateTime.Now.AddSeconds(5);
        DateTime futureTime2 = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < futureTime1)
        {
            Console.Write("Well Done!!\n");
            Animation(5);
        }
        while (DateTime.Now < futureTime2)
        {
            Console.Write($"You have completed another {_duration} seconds of the {_name}\n");
            Animation(5);
        }
    }

    protected void Intro()
    {
        //displays intro message with each activty, changes depending on the one that calls it.
        SetIntro();
        Console.WriteLine(_welcome);
        //retrives time from the user
        GetDuration();
    }

    private void SetIntro()
    {
        string deets = "";
        if (_name == "Breathing Activity")
        {
            deets = "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        else if (_name == "Reflection Activty")
        {
            deets = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (_name == "Listing Activty")
        {
            deets = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
        else if (_name == "Serenity Activity")
        {
            deets = "This activity will help you reach total serenity by contemplating the visage of the perfect creation, and summoner of the 'Swamp of Serenity'.";
        }
        _welcome = "Welcome to the " + _name + "\n\n" + deets + "\n";
    }
}