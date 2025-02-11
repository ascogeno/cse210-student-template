using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture script = new Scripture();
        //Right under here is the scripture reference and text. These can be freely swapped out
        string reference = "Proverbs 3:5-6";
        string scriptText = "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.";
        //Just make sure to delete any "tabs" as seperators between verses
        script.SetScripture(scriptText);
        script.SetReference(reference);
        script.InitializeImpurities();
        script.Display();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string input = Console.ReadLine().ToLower();
        while (input != "quit")
        {
            Console.Clear();
            script.Remove();
            script.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine().ToLower();
            if (script.CheckIfAllUnderScored())
            {
                input = "quit";
            }
        }
    }
}