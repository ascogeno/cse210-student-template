using System;
using System.ComponentModel.Design;
using System.IO.Enumeration;

class Program
{
    static string filename = "";
    static bool changed = false;
    static bool loaded = false;
    static Journal journo = new Journal();
    static void Main(string[] args)
    {
        string response = "";
        Console.WriteLine("Welcome to the Journal Program!");
        while (response != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            response = Console.ReadLine();
            Menu(response);
        }
    }

    public static void Menu(string choice)
    {
        //calls other stuff depending on the number entered
        if (choice == "1")//Write
        {
            changed = true;
            string prompt = GetRandomString();
            journo.Add(prompt);

        }
        if (choice == "2")//Display
        {
            if (journo.HasEntries())
            {
                journo.Display();
            }
            else
            {

                Console.WriteLine("Nothing to display, bub. Make something before I display it");
            }
        }
        if (choice == "3")//Load
        {
            Console.WriteLine("What is the filename?: ");
            filename = Console.ReadLine();
            journo.Load(filename);
            loaded = true;
        }
        if (choice == "4")//Save
        {
            changed = true;
            Console.WriteLine("Save as what filename?: ");
            filename = Console.ReadLine();
            journo.Save(filename);

        }
        if (choice == "5")//Quit
        {
            if (changed)
            {
                Console.WriteLine("You sure? There's some stuff you might want to save. Would you like to Save? (y/n): ");
                string urgentResponse = Console.ReadLine().ToLower();
                if (urgentResponse == "y")
                {
                    Console.WriteLine("Save as what filename?: ");
                    filename = Console.ReadLine();
                    journo.Save(filename);
                }
            }
            else
            {
                Console.WriteLine("See you later!");
            }
        }
    }

    public static string GetRandomString()
    {
        List<string> Prompts = ["Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?",
                        "Who did I have fun talking to today?",
                        "What about today would I have changed?"];
        Random randy = new Random();
        int randomPrompt = randy.Next(Prompts.Count);
        return Prompts[randomPrompt];
    }
}