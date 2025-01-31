using System;
using System.IO;
using System.Collections.Generic;

class Journal
{
    private List<Entry> TotalEntries = new List<Entry>();

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, false)) //debug, change to true for appending vs overwriting file
        {
            foreach (Entry entry in TotalEntries)
            {
                outputFile.WriteLine(entry.currentEntryText);
            }
        }
    }

    public bool HasEntries()
    {
        return TotalEntries.Count > 0;
    }

    public void Load(string filename)
    {

        if (File.Exists(filename))
        {
            TotalEntries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry currentEntry = new Entry();
                    currentEntry.currentEntryText = line;
                    TotalEntries.Add(currentEntry);
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid filename.");
        }
    }

    public void Display()
    {
        foreach (Entry entry in TotalEntries)
        {
            Console.WriteLine($"{entry.currentEntryText}\n");
        }
    }

    public void Add(string prompt)
    {
        Entry currentEntry = new Entry();
        currentEntry.currentEntryText = currentEntry.Write(prompt);
        TotalEntries.Add(currentEntry);
    }
}