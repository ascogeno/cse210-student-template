using System;

class Breathe : Activity
{
    //these are unused, from an earier idea for the project
    //might use them later for modifying this activity to functin differently, but for now they keep the constructor company
    private int breathIn;
    private int breathOut;
    public Breathe() : base("Breathing Activity")
    {
        breathIn = 0;
        breathOut = 0;
    }

    public void Run()
    {
        //runs the activity. unsure if this is needed or not
        Intro();
        GetReady();
        BreathInAndOut();
        WellDone();
    }
    private void BreathInAndOut()
    {
        //loops breathing in an out, based on time given
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        //initial breathe in and out
        Console.Write("Breathe in...");
        CountDown(2);
        Console.Write("Now breathe out...");
        CountDown(3);
        Console.Write("\n");
        //deeper breaths
        if (DateTime.Now < futureTime)
        {
            while (DateTime.Now < futureTime)
            {
                Console.Write("Breathe in...");
                CountDown(4);
                Console.Write("Now breathe out...");
                CountDown(6);
                Console.Write("\n");
            }
        }
    }
}