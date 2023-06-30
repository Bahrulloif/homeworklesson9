public class Circle : Shape
{
    protected double radius;
    private const double _pi = 3.14;
    public Circle(double radius)
    {
        this.radius=radius;
    }
    public Circle()
    {
        
    }
    public override double Area()
    {
        return _pi* radius * radius;
    }
    public override double Perimeter()
    {
        return 2 * _pi * radius;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}