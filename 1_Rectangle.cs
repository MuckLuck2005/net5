using System;

class Rectangle : Figure
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return width * height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}
