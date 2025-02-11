using System;

class Program
{
    static List<Scripture> scriptures = new List<Scripture>();
    static void Main(string[] args)
    {
        Console.Clear();
        //Right under here is the scripture reference and text. These can be freely swapped out
        string reference1 = "3rd Nephi 11:10-11";
        string scriptText1 = "10 Behold, I am Jesus Christ, whom the prophets testified shall come into the world. 11 And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.";
        string reference2 = "Proverbs 3:5-6";
        string scriptText2 = "5 ¶ Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.";
        string reference3 = "Proverbs 21:19";
        string scriptText3 = "19 It is better to dwell in the wilderness, than with a contentious and an angry woman.";
        //Just make sure to delete any "tabs" as seperators between verses
        Scripture script1 = new Scripture(scriptText1, reference1);
        Scripture script2 = new Scripture(scriptText2, reference2);
        Scripture script3 = new Scripture(scriptText3, reference3);
        scriptures.Add(script1);
        scriptures.Add(script2);
        scriptures.Add(script3);
        Scripture chosenOne = scriptures[GetRandomScripture()];
        chosenOne.Display();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string input = Console.ReadLine().ToLower();
        while (input != "quit")
        {
            Console.Clear();
            chosenOne.Remove();
            if (!chosenOne.CheckIfAllUnderScored())
            {
                chosenOne.Remove();
            }
            if (!chosenOne.CheckIfAllUnderScored())
            {
                chosenOne.Remove();
            }
            chosenOne.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine().ToLower();
            if (chosenOne.CheckIfAllUnderScored())
            {
                input = "quit";
            }
        }
    }

    static int GetRandomScripture()
    {
        int numberOf = scriptures.Count;
        Random randy = new Random();
        return randy.Next(0, numberOf);
    }
}