using System;

class Word
{
    private string currentWord;
    private bool underScored;

    public Word()
    {
        currentWord = "";
        underScored = false;
    }
    public Word(string word)
    {
        currentWord = word;
        underScored = false;
    }

    public void GetRidOfCertainCharacters()
    {
        if (currentWord == "¶")
        {
            currentWord = "";
        }
        else if (currentWord.Substring(currentWord.Length - 1) == ".")
        {
            currentWord = currentWord.Substring(0, currentWord.Length - 1);
        }
        else if (currentWord.Substring(currentWord.Length - 1) == ";")
        {
            currentWord = currentWord.Substring(0, currentWord.Length - 1);
        }
    }

    public string GetWord()
    {
        return currentWord;
    }

    public void SetUnderScore()
    {
        underScored = true;
        currentWord = getHiddenVersion();
    }

    public bool GetUnderScore()
    {
        return underScored;
    }

    public string getHiddenVersion()
    {
        int wordLength = currentWord.Length;
        string hidden = "";
        for (int i = 0; i < wordLength; i++)
        {
            hidden += "_";
        }
        return hidden;
    }
}