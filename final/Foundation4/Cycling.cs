public class Cycling : Activity
{
    double _speed;
    public Cycling(string date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * _minutesTime, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutesTime} min)- Distance: {GetDistance()} meters, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km";
    }
}
