using System;

class ChecklistGoal : Goal
{
    private int completed;
    private int totalToComplete;
    private int finishPoint;

    public ChecklistGoal()
    {
        //this should not be called
        Console.WriteLine("UHHHHH I SHOULD NOT HAVE BEEEN CALLED (BASE CHECKLISTGOAL CONSTRUCTOR)");
    }

    public ChecklistGoal(string name, string desciption, int points, int total, int finalPoints) : base(name, desciption, points)
    {
        completed = 0;
        totalToComplete = total;
        finishPoint = finalPoints;
    }

    public ChecklistGoal(string representation)
    {
        //add code for decoding strings
        string[] parts = representation.Split(";");
        if (parts.Length == 7 && int.TryParse(parts[3], out int point) && int.TryParse(parts[4], out int bonus) && int.TryParse(parts[5], out int target) && int.TryParse(parts[6], out int currentCompleted))
        {
            name = parts[1];
            description = parts[2];
            points = point;
            totalToComplete = target;
            finishPoint = bonus;
            completed = currentCompleted;
        }
    }

    public override void Edit()
    {
        Console.WriteLine("You can edit the:\n  1.Name\n  2.Description\n  3.Points\n  4.Target\n  5.Bonus Points");
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
            case "4":
                Console.Write("Enter the new target: ");
                totalToComplete = int.Parse(Console.ReadLine());
                break;
            case "5":
                Console.Write("Enter the new bonus points: ");
                finishPoint = int.Parse(Console.ReadLine());
                break;
        }
        Console.WriteLine("Would you like to reset this goal's progress? (y/n)");
        string choice = Console.ReadLine().ToLower();
        if (choice == "y")
        {
            completed = 0;
        }
        Console.WriteLine("WARNING: Edit is temporary. Save if you wish to keep changes");
    }

    public override void Display()
    {
        string x = " ";
        if (IsCompleted())
        {
            x = "x";
        }
        Console.WriteLine($"[{x}] {GetName()} ({GetDesc()}) -- Currently Completed: {completed}/{totalToComplete}");

    }

    public override string GetRep()
    {
        return $"ChecklistGoal;{name};{description};{points};{finishPoint};{totalToComplete};{completed}";
    }

    protected override bool IsCompleted()
    {
        if (completed == totalToComplete || completed > totalToComplete)
        {
            return true;
        }
        return false;
    }

    public override void SetCompleted()
    {
        completed++;
    }

    public override int GetGoalPoint()
    {
        //adjust logic so that total completed/goal gives bonus. if goal is 3, every 3 bonus points should be awarded
        //fix logic so that points aren't multiplied a lot
        int markiplier = completed / totalToComplete;
        return points + (markiplier * finishPoint);
    }
}