public class Square : Shape
{
    private double _side;

    public Square(string shapeName, string color, double side) : base(shapeName, color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * 4;
    }

    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
}