public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color)
    {
        _radius = radius;
        SetColor(color);
    }
    public override double GetArea()
    {
        double area = 3.1416 * Math.Pow(_radius, 2);
        return area;
    }
}