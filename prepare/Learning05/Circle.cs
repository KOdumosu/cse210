public class Circle : Shape
{
    private double _radius;

    public Circle(string shapeName, string color, double radius) : base(shapeName, color)
    {
        _radius = radius;
    }



    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }

    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
}