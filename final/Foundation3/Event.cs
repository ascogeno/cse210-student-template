public abstract class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    Address addy;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        addy = new Address(address);
    }

    public string GetStandardDeets()
    {
        return $"Deets for {_title}: {_description}, on {_date} at {_time}, at {addy.GetAddresss()}";
    }

    public abstract string FullDeets();
    public abstract string ShortDeets();
}