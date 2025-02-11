using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture script = new Scripture();
        //Right under here is the scripture reference and text. These can be freely swapped out
        string reference = "3rd Nephi 11:10-11";
        string scriptText = "10 Behold, I am Jesus Christ, whom the prophets testified shall come into the world. 11 And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.";
        //Just make sure to delete any "tabs" as seperators between verses
        script.InitializeImpurities(scriptText, reference);
        script.Display();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string input = Console.ReadLine().ToLower();
        while (input != "quit")
        {
            Console.Clear();
            script.Remove();
            script.Remove();
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