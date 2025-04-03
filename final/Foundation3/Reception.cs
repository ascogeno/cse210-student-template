using System.Runtime.InteropServices;

class Reception : Event
{
    private string _reserveEmail;

    public Reception(string title, string description, string date, string time, string adddress, string email) : base(title, description, date, time, adddress)
    {
        _reserveEmail = email;
    }

    public bool IsElligibleToEnroll()
    {
        return false;
    }

    public override string FullDeets()
    {
        return $"{GetStandardDeets()}. Please email us to RSVP: {_reserveEmail}";
    }

    public override string ShortDeets()
    {
        return $"Reception: {_title} on {_date}";
    }
}