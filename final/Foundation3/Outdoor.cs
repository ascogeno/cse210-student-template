using System.Runtime.CompilerServices;

class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDeets()
    {
        return $"{GetStandardDeets()}. UPDATED WEATHER ADVISORY: Currently the scheduled event is to have {_weather}";
    }

    public override string ShortDeets()
    {
        return $"Outdoors Activity: {_title} on {_date}";
    }
}