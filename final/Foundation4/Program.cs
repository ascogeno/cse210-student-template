using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activies = new List<Activity>();
        Running ran = new Running("Nov 10, 1996", 50, 19.2);
        Cycling circle = new Cycling("Nov 16, 2001", 45, 7.87);
        Swimming swam = new Swimming("Septmeber 21, 1998", 25, 24);
        activies.Add(ran);
        activies.Add(circle);
        activies.Add(swam);
        foreach (Activity active in activies)
        {
            Console.WriteLine(active.GetSummary());
        }
    }
}