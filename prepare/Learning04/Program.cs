using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment stewey = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(stewey.GetSummary());
        Console.WriteLine(stewey.GetWritingInformation());
    }
}