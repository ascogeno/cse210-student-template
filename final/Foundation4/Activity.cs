public abstract class Activity
{
    protected string _date;
    protected int _minutesTime;

    public Activity(string date, int time)
    {
        _date = date;
        _minutesTime = time;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}