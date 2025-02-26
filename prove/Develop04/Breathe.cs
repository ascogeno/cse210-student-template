using System;

class Breathe : Activity
{
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
    }
    private void SetIntervals()
    {
        //Sets breathing intervals. Needed since if a user says 5 seconds, the timer shouldn't start at 6 and then end early
    }

    private void BreathInAndOut()
    {
        //loops breathing in an out, based on time given
    }
}