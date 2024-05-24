public class Shape
{
    private string _shapeName;
    private string _color;

    public Shape(string shapeName, string color)
    {
        _shapeName = shapeName;
        _color = color;
    }

    public string GetShapeName()
    {
        return _shapeName;
    }
    public void SetShapeName(string shapeName)
    {
        _shapeName = shapeName;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return -1;
    }


}