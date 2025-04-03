using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecturn = new Lecture("How to wear a patgonia vest or die trying", "A comprehsive instruction hour into the ins and outs of wearing patagoina vests", "10-28-2003", "10:46pm", "1 Dove Tree Road, Wewoka OK", "Bill Gates", 49);
        Reception reciept = new Reception("Love and War: Together at last", "The open house Reception for the concepts of Love and War", "13-32-2027", "25:61am", "142 S 2nd E, Rexburg, ID 83460", "comeaul@byui.edu");
        Outdoor insideOut = new Outdoor("How to touch grass: A Panel", "There are many who are afflicted with the inability to act on their copious invitations to touch grass. This safe space provides them that chance", "4/1/2025", "7:00am", "505 S Center St, Rexburg, ID 83460", "Clear, Sunny Skies");
        MarketingMessages(lecturn);
        MarketingMessages(reciept);
        MarketingMessages(insideOut);
    }

    public static void MarketingMessages(Event e)
    {
        Console.WriteLine("Current Marketing Materials for this event: ");
        Console.WriteLine($"Standard Details: {e.GetStandardDeets()}\n");
        Console.WriteLine($"Full Details: {e.FullDeets()}\n");
        Console.WriteLine($"Short Details: {e.ShortDeets()}\n\n");
    }
}