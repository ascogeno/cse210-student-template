using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

class Program //add progress bar to purchase of item (say a child is using the program. Progress bar fills to thing based off points)
{
    static List<Goal> Goals = new List<Goal>();
    static int pointsTotal;
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine($"\nYou have {pointsTotal} points\n");
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Edit Goal\n  7. Quit");
            Console.Write("Select a choice from the menu: ");

            //I learned about switch statements mwahaha
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    //Create New Goal
                    CreateGoals();
                    break;
                case "2":
                    //List Goals
                    Display();
                    break;
                case "3":
                    //Save Goals
                    Console.WriteLine("What is the filename for the goal file? ");
                    string savename = Console.ReadLine();
                    Save(savename);
                    break;
                case "4":
                    //Load Goals
                    Console.WriteLine("What is the filename for the goal file? ");
                    string loadname = Console.ReadLine();
                    Load(loadname);
                    break;
                case "5":
                    //Record Event
                    if (Goals.Count > 0)
                    {
                        Console.WriteLine("The goals are:");
                        int count = 0;
                        foreach (Goal gaol in Goals)
                        {
                            count++;
                            Console.WriteLine($"{count}. {gaol.GetName()}");
                        }
                        Console.Write("What goal did you accomplish? ");
                        int listIndex = int.Parse(Console.ReadLine()) - 1;
                        while (listIndex < 0 || listIndex >= Goals.Count)
                        {
                            Console.Write("Cmon, don't break the program dude. Enter a valid number: ");
                            listIndex = int.Parse(Console.ReadLine()) - 1;
                        }
                        Goals[listIndex].SetCompleted();
                        Console.WriteLine($"Congratulations! You have earned {Goals[listIndex].GetGoalPoint()} points!");
                        pointsTotal = pointsTotal + Goals[listIndex].GetGoalPoint();
                        Console.WriteLine($"You now have {pointsTotal} points.");
                    }

                    break;
                case "6":
                    //edit goal
                    if (Goals.Count > 0)
                    {
                        EditGoals();
                    }
                    break;
                case "7":
                    //exit program
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Hey there, bub. Choose a real option why dontcha");
                    break;
            }
        }

    }

    private static void CreateGoals()
    {
        Console.Write("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
        string goal = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short desciption of your goal? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        switch (goal)
        {
            case "1":
                SimpleGoal simp = new SimpleGoal(name, desc, points);
                Goals.Add(simp);
                break;
            case "2":
                ETGoal atari = new ETGoal(name, desc, points);
                Goals.Add(atari);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int total = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for completing it that many times?");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal check = new ChecklistGoal(name, desc, points, total, bonus);
                Goals.Add(check);
                break;
        }
    }

    private static void EditGoals()
    {
        Console.WriteLine("Goals to edit are:");
        int count = 0;
        //add a check for if the list has entries in it
        foreach (Goal gaol in Goals)
        {
            count++;
            Console.Write($"{count}. ");
            gaol.Display();
        }

        Console.Write("Which goal would you like to edit? ");
        int listIndex;
        while (!int.TryParse(Console.ReadLine(), out listIndex) || listIndex < 1 || listIndex > Goals.Count)
        {
            Console.Write("Cmon, don't break the program dude. Enter a valid number: ");
        }

        Goals[listIndex - 1].Edit();
    }

    private static void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, false)) //debug, change to true for appending vs overwriting file
        {
            outputFile.WriteLine($"{pointsTotal}");
            foreach (Goal gaol in Goals)
            {
                outputFile.WriteLine($"{gaol.GetRep()}");
            }
        }
    }

    private static void Load(string filename)
    {
        if (File.Exists(filename))
        {
            Goals.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string firstLine = reader.ReadLine();
                if (firstLine != null && int.TryParse(firstLine, out int pointTotal))
                {
                    pointsTotal = pointTotal;
                }
                else
                {
                    Console.WriteLine("Invalid point total in file.");
                    return; //debugging early exit
                }
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //this should split up each line with all the semicolons
                    string[] parts = line.Split(";");
                    if (parts.Length > 0)
                    {
                        string goalType = parts[0];
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                Goals.Add(new SimpleGoal(line));
                                break;
                            case "EternalGoal":
                                Goals.Add(new ETGoal(line));
                                break;
                            case "ChecklistGoal":
                                Goals.Add(new ChecklistGoal(line));
                                break;
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid filename.");
            return;
        }
    }

    private static void Display()
    {
        Console.WriteLine("The Goals are:");
        int count = 0;
        //add a check for if the list has entries in it
        foreach (Goal gaol in Goals)
        {
            count++;
            Console.Write($"{count}. ");
            gaol.Display();
        }
    }
}