using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n   1. Start breathing activity\n   2. Start reflection activity\n   3. Start listing activity\n   4. Quit\n   5. Swamp of Serenity\nSelect a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Breathe breth = new Breathe();
                Console.Clear();
                breth.Run();
            }

            else if (choice == "2")
            {
                Reflection mirror = new Reflection();
                Console.Clear();
                mirror.Run();
            }

            else if (choice == "3")
            {
                Listing list = new Listing();
                Console.Clear();
                list.Run();
            }

            else if (choice == "5")
            {
                Serenity simon = new Serenity();
                Console.Clear();
                simon.Run();
            }

            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                Console.WriteLine("Please enter a valid numer");
            }
        }
        //need to figure out opening prompt. currently, I need data from the user after the constructor is called that actaully
        //takes in that info. rearrangement necessary
    }
}