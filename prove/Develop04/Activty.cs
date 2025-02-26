using System;

class Activity
{
    private string _name; //base for welcome messsage, modified as needed by intro function
    private int _duration; //stores the duration by the user. measured in seconds
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

    public void GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like your session? ");
        _duration = Int32.Parse(Console.ReadLine());
    }

    public string Animation()
    {
        //loops through these characters |\-/
        return "";
    }

    public string GetReady()
    {
        //displays "Get ready..." before the activities. See demo video
        return "";
    }

    public string WellDone()
    {
        //displays ending message for each activity. See demo video
        return "";
    }

    private void Intro()
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
        if (_name == "Breathing Activty")
        {
            deets = "This Activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        if (_name == "Reflection Activty")
        {
            deets = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        if (_name == "Listing Activty")
        {
            deets = "This activity will hell you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
        _welcome = "Welcome to the" + _name + "\n\n" + deets;
    }
}