using System;

class ETGoal : Goal
{
    public ETGoal()
    {
        //this should not be called
        Console.WriteLine("UHHHHH I SHOULD NOT HAVE BEEEN CALLED (BASE ETGOAL CONSTRUCTOR)");
    }

    public ETGoal(string name, string description, int points) : base(name, description, points)
    {
        //nothing needs to be done here
    }

    public ETGoal(string representation)
    {
        //add code for decoding strings to then construct this thing
        string[] parts = representation.Split(";");
        if (parts.Length == 4 && int.TryParse(parts[3], out int point))
        {
            name = parts[1];
            description = parts[2];
            points = point;
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
        Console.WriteLine("WARNING: Edit is temporary. Save if you wish to keep changes");
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDesc()})");
    }

    public override string GetRep()
    {
        return $"EternalGoal;{name};{description};{points}";
    }

    public override void SetCompleted()
    {
        //nope
    }

    protected override bool IsCompleted()
    {
        return false;
    }
}