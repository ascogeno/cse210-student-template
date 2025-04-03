public class Running : Activity
{
    double _distance;
    public Running(string date, int time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / _minutesTime) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(_minutesTime / _distance, 2);
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutesTime} min)- Distance: {GetDistance()} meters, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km";
    }
}