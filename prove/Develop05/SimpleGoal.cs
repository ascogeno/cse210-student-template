using System;
using System.Runtime.CompilerServices;

class SimpleGoal : Goal
{
    private bool completed;
    public SimpleGoal()
    {
        //this should not be called
        Console.WriteLine("UHHHHH I SHOULD NOT HAVE BEEEN CALLED (BASE SIMPLEGOAL CONSTRUCTOR)");
    }

    public SimpleGoal(string name, string desciption, int points) : base(name, desciption, points)
    {
        //nothing else needs to be done in here
        completed = false;
    }

    public SimpleGoal(string representation)
    {
        //add code for decoding strings, then reassigning variables.
        string[] parts = representation.Split(";");
        if (parts.Length == 5 && int.TryParse(parts[3], out int point) && bool.TryParse(parts[4], out bool isComplete))
        {
            name = parts[1];
            description = parts[2];
            points = point;
            completed = isComplete;
        }
    }

    public override void Edit()
    {
        Console.WriteLine("You can edit the:\n  1.Name\n  2.Description\n  3.Points\n");
        Console.Write("Which attribute would you like to edit? ");
        string toEdit = Console.ReadLine();
        switch (toEdit)
        { 
            case "1":
                Console.Write("Enter the new name: ");
                name = Console.ReadLine();
                break;
            case "2":
                Console.Write("Enter the new description: ");
                description = Console.ReadLine();
                break;
            case "3":
                Console.Write("Enter the new points: ");
                points = int.Parse(Console.ReadLine());
                break;
        }
        Console.WriteLine("Would you like to reset this goal's completion? (y/n)");
        string choice = Console.ReadLine().ToLower();
        if (choice == "y")
        {
            completed = false;
        }
        Console.WriteLine("WARNING: Edit is temporary. Save if you wish to keep changes");
    }

    public override void SetCompleted()
    {
        completed = true;
    }

    protected override bool IsCompleted()
    {
        return completed;
    }

    public override void Display()
    {
        string x = " ";
        if (IsCompleted())
        {
            x = "x";
        }
        Console.WriteLine($"[{x}] {GetName()} ({GetDesc()})");
    }

    public override string GetRep()
    {
        return $"SimpleGoal;{name};{description};{points};{completed}";
    }
}