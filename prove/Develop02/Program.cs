using System;
using System.ComponentModel.Design;
using System.Text;
using System.IO.Enumeration;
using System.Reflection;

class Program
{
    static string filename = "";
    static bool changed = false;
    static Journal journo = new Journal();
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string response = "";
        Console.WriteLine("Welcome to the Journal Program!");
        while (response != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n6. Secret Option\nWhat would you like to do?");
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
        if (choice == "6")
        {
            Console.WriteLine("Usage of this option needs special clearnance, do you have such clearance? (y/n): ");
            string currentReponse = Console.ReadLine().ToLower();
            if (currentReponse == "y")
            {
                Console.WriteLine("Are you sure? This is truly top secret, we can't be having any leaks now. This intelligence could threaten our national security if it gets leaked. Do you truly have such clearnance? (y/n): ");
                string evenMoreCurrentResponse = Console.ReadLine();
                if (evenMoreCurrentResponse == "y")
                {
                    Console.WriteLine("Alright, here you go: ");
                    Console.WriteLine(@"
⡏⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⣉⣩⣭⣉⣉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠋⢁⣀⠀⣀⡈⠙⢢⡀⠀⠒⠒⠂⣀⡤⠖⠒⠒⠒⠢⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠏⠀⢰⣿⣿⡿⠛⠃⠀⠀⣹⠀⠀⠀⠸⡇⠀⠀⢰⣶⣤⣀⠀⠱⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠀⠀⣾⠏⠉⠁⠀⢀⡠⠞⠋⠀⠀⠀⠀⠻⣄⠀⠀⠨⢿⣿⡷⠄⠸⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡤⠿⡀⠈⠀⢀⣀⠤⠚⠉⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⣄⠀⠀⠹⣷⡆⢀⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⢀⡴⠋⠁⠀⢀⠝⠋⠙⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⣄⡀⠀⠀⡼⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⢠⢏⣴⠀⢀⡞⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠓⠚⠙⠢⡀⠀⡀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⢀⡏⡞⢸⡄⠨⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠸⡇⡇⢸⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡖⢳⡄⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⡇⣷⠈⠉⢷⠀⢠⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⡧⣾⠃⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⢸⡘⡆⠀⠙⣆⠀⠈⠑⠦⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡤⠞⠋⢰⣿⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⣳⣳⠀⠀⠘⣆⠀⠀⠀⠀⠉⠙⠛⠿⠶⢤⣤⠤⠤⠤⠤⠶⠆⠐⠂⠀⠀⠀⠀⠀⠀⠀⠀⣼⢏⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⢀⣠⠴⠚⢉⣡⣡⡁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣯⠇⢀⡄⠀⠀⠀⠀⠀
⣇⡤⠖⣉⣀⣠⣴⠞⠋⠁⣷⠐⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⢞⠗⠁⣠⠟⠀⠀⠀⠀⠀⠀
⡧⣚⠿⠛⠉⠊⠁⠀⠀⠀⣿⡄⢈⢳⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠟⠂⠁⠀⠈⠁⣀⠔⠁⠀⠀⠀⠀
⡏⠁⠀⠀⠀⠀⠀⠀⠀⢀⣿⣇⠀⠳⡑⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠛⠁⠀⠀⢀⡠⠖⠉⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⡀⢀⠀⠰⢾⣿⡀⠀⠙⣆⠣⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠞⣿⠇⠀⠀⠀⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⡠⠊⠁⠀⠀⠘⠈⣿⣧⠀⠀⠹⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠃⢀⡇⠀⠀⠀⠸⡿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⡠⠊⠀⠀⠀⠀⠀⠀⠀⠹⣿⡀⠀⠀⠈⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⠃⠀⠘⡆⠀⠀⠀⠀⠘⠼⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠃⠀⢄⠀⣧⠀⠀⠀⠀⠀⠀⢣⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⢀⣀⡤⠤⠴⢲⠃⠀⠀⠈⠳⢦⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠸⠁⠀⠀⠈⢧⢹⡄⠀⠀⠀⠀⠀⠘⡆⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠈⠉⠉⠀⠀⠀⢀⠏⠀⠀⠀⠀⠀⠀⠈⠀⠉⠙⠒⠒⠒⠀⠐⠒⠀⠀⠀⠀⠀⠀⠈⠀⢷⠀⠀⠀⠀⠀⠀⢳⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⢀⡞⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣀⠀⠀⠀⠀⠘⡇⠀⠀⠀⠀⠀⠘⡆⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⡼⠀⠀⠀⠀⠀⠀⣠⠴⡄⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⢸⣿⣷⣤⡀⠀⠀⢻⡄⠀⠀⠀⠀⠀⢹⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⡼⠁⠀⠀⠀⠀⣠⠞⠁⠀⡇⠀⠀⠀⠀⠀⢠⣧⠀⠀⠀⠀⣾⡟⠛⠉⠙⠳⢦⣄⣧⠀⠀⠀⠀⠀⠈⠧⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⣼⠃⠀⠀⢀⡴⠊⠀⠀⠀⠀⡇⠀⠀⠀⠀⢀⡟⠸⡇⠀⠀⢸⠛⣧⠀⠀⠀⠀⠀⠈⢻⡀⠀⠀⠀⠀⠀⠀⠄⠀⠀⠀⠀⠀
⡇⠀⠀⠀⣸⠃⠀⢀⡴⠋⠀⠀⠀⠀⠀⢠⡇⠀⠀⠀⠀⣼⠁⢰⢿⠀⠀⡏⠀⠘⣷⡄⠀⠀⠀⠀⠀⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠸⡏⢀⡴⠋⠀⠀⠀⠀⠀⠀⠀⢘⡇⠀⠀⠀⣰⠃⡀⡀⢸⡇⠀⡇⠀⠀⣸⣷⡀⠀⠀⠀⠀⠘⠆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⡷⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠨⡇⠀⠀⢰⠃⠀⠀⠀⢸⡇⢸⢃⣤⣾⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⠀⣰⠏⠀⠀⠀⠀⢹⡇⣼⣿⣿⡿⠉⠀⠹⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠇⣰⠋⠀⠀⠀⠀⠀⠈⢡⣿⡿⠟⠀⠀⠀⠀⠙⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀⢘⣿⠧⠀⠀⠀⠀⠀⠀⠒⠛⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡿⠀⠀⠀⢀⣸⣥⡤⠶⠒⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣇⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀⣠⣭⣥⣽⣶⣿⣿⣷⣦⣤⣤⣤⣤⣤⣦⣄⣀⣀⣀⣀⣀⣀⣀⣀⣀⣀");
                }
                else
                {
                    Console.WriteLine("Then get outta here. Shoo");
                }
            }
            else
            {
                Console.WriteLine("That's what I thought. Now scram");
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
                        "What about today would I have changed?",
                        "What is something new I learned today?",
                        "What is one thing I accomplished today that I’m proud of?",
                        "If today was a book or movie, what would its title be?",
                        "What was something funny or lighthearted that happened today?",
                        "What’s one way I can make tomorrow even better than today?"];
        Random randy = new Random();
        int randomPrompt = randy.Next(Prompts.Count);
        return Prompts[randomPrompt];
    }
}