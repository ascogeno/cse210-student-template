using System;

class Listing : Activity
{
    private List<string> _promptList;
    private int counter;

    public Listing() : base("Listing Activty")
    {
        _promptList = [];
        counter = 0;
    }

    private void DisplayPrompt()
    {
        //displays a random prompt
    }

    private void CountInput()
    {
        //increments counter and formats console like the demo video
    }

    public void Run()
    {
        //packages everything together so I can just call this from Program
    }
}