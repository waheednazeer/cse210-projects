public class Rectangle : Shape
{
    private double _width = 0;
    private double _length = 0;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _width = width;
        _length = length;
    }



    public override double GetArea()
    {
        return _width*_length;
    }
}