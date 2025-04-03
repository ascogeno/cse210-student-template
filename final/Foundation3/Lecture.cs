class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDeets()
    {
        return $"{GetStandardDeets()}, Featuring guest Speaker: {_speaker}. Only enough room for {_capacity} attendees";
    }

    public override string ShortDeets()
    {
        return $"Lecture: {_title} on {_date}";
    }
}