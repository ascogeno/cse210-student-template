using System.Reflection.Metadata;

class Entry
{
    DateTime theCurrentTime = DateTime.Now;
    public string currentEntryText;
    public string currentPromptText;
    public string Write(string prompt)
    {
        currentPromptText = prompt;
        Console.WriteLine($"{prompt}");
        currentEntryText = Console.ReadLine();
        return "Date: " + theCurrentTime.ToShortDateString() + $" - Prompt: {prompt}\n" + currentEntryText;
    }
}