using System;
using System.ComponentModel.DataAnnotations;

class Scripture
{
    private string refString;
    private Reference _ref;
    private List<List<Word>> verseList;
    private string currentScripture;
    private List<string> impureList;
    private Random randy = new Random();

    public Scripture()
    {
        refString = "";
        _ref = new Reference();
        verseList = new List<List<Word>>();
        currentScripture = "";
        impureList = new List<string>();
    }

    public Scripture(string scriptText, string reference)
    {
        currentScripture = scriptText;
        refString = reference;
        impureList = new List<string>(currentScripture.Split(" "));
        verseList = new List<List<Word>>();
        _ref = new Reference(refString);
        setList();
    }

    public void Display()
    {
        ProcessWords();
        Console.Write($"{_ref.getReference()}");
        int lastVerseIndex = verseList.Count - 1; // Get the index of the last verse

        for (int verseIndex = 0; verseIndex < verseList.Count; verseIndex++)
        {
            foreach (Word currentWord in verseList[verseIndex])
            {
                Console.Write($" {currentWord.GetWord()}");
            }
            if (verseIndex != lastVerseIndex)
            {
                Console.Write(";");
            }
            if (verseIndex == lastVerseIndex)
            {
                Console.Write("\n\n");
            }
        }
    }

    public void Remove()
    {
        int randomVerse, randomWord;
        bool found = false;

        while (!found)
        {
            randomVerse = GetRandomVerse();
            randomWord = GetRandomWord(randomVerse);

            if (!verseList[randomVerse][randomWord].GetUnderScore())//Checks if the word is underscored
            {
                verseList[randomVerse][randomWord].SetUnderScore();
                found = true;
            }
        }
    }

    public void setList() //don't hurt me. My idea for this function was too complex for my monkey brain, AI helped me with it
    {
        verseList.Clear(); // Start fresh
        List<Word> currentVerse = null; // No active verse initially

        foreach (string impure in impureList)
        {
            if (int.TryParse(impure, out int verseNumber))
            {
                // Start a new verse, but skip adding the number itself
                currentVerse = new List<Word>();
                verseList.Add(currentVerse);
                continue; // Skip the number and move to the next word
            }
            // Create a Word object and set its value
            Word wordObj = new Word(impure);
            currentVerse.Add(wordObj);
        }
    }

    public int GetRandomVerse()
    {
        return randy.Next(0, verseList.Count);
    }

    public int GetRandomWord(int randomVerse)
    {
        return randy.Next(0, verseList[randomVerse].Count);
    }

    public bool CheckIfAllUnderScored()
    {
        bool no = true;
        foreach (List<Word> verse in verseList)
        {
            foreach (Word currentWord in verse)
            {
                if (!currentWord.GetUnderScore())//checks if the word isn't underscored
                {
                    no = false;
                    continue;
                }
            }
            if (no == false)
            {
                continue;
            }
        }
        return no;
    }

    public void ProcessWords() //I had a last minute idea, and made AI do it cause it was midnight. Sue me.
    {
        // Iterate through all verses
        for (int verseIndex = 0; verseIndex < verseList.Count; verseIndex++)
        {
            List<Word> verse = verseList[verseIndex];

            // Iterate through each word in the verse
            for (int wordIndex = 0; wordIndex < verse.Count; wordIndex++)
            {
                Word currentWord = verse[wordIndex];

                // If it's the last word of the last verse, skip processing
                if (verseIndex == verseList.Count - 1 && wordIndex == verse.Count - 1)
                {
                    continue;
                }

                // Call GetRidOfCertainCharacters on every word that isn't the last word of the last verse
                currentWord.GetRidOfCertainCharacters();
            }
        }
    }
}