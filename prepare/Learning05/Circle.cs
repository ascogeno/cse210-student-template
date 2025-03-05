using System;

class Circle : Shape
{
    private double _radius;

    public Circle(double radi, string color) : base(color)
    {
        _radius = radi;
    }

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}