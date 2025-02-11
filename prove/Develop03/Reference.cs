using System;

class Reference
{
    private string refString;

    public Reference()
    {
        refString = "";
    }
    public Reference(string reference)
    {
        refString = reference;
    }

    public string getReference()
    {
        return refString;
    }
}