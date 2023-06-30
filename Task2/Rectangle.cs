public class Rectangle : Shape
{
    protected double side1 { get; set; }
    protected double side2 { get; set; }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public Rectangle()
    {

    }
    public override double Area()
    {
        return side1 * side2;
    }
    public override double Perimeter()
    {
        return 2 * (side1 + side2);
    }
    public override string ToString()
    {
        return base.ToString();
    }
}