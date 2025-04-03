public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double initialMath = _laps * 50 / 1000;
        return Math.Round(initialMath, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / _minutesTime) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutesTime} min)- Laps: {_laps}, Distance: {GetDistance()} meters, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km";
    }
}