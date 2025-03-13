using System;
using System.Dynamic;

public abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;
    public Goal()
    {
        //this should not be called
        //Console.WriteLine("UHHHHH I SHOULD NOT HAVE BEEEN CALLED (BASE GOAL CONSTRUCTOR)");
    }

    public Goal(string n, string d, int p)
    {
        name = n;
        description = d;
        points = p;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDesc()
    {
        return description;
    }
    protected abstract bool IsCompleted();
    public abstract void SetCompleted();
    public abstract void Display();
    public abstract string GetRep();
    public abstract void Edit();
    public virtual int GetGoalPoint()
    {
        return points;
    }

}