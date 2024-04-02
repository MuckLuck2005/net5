using System;

abstract class Figure
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Тип фігури: {GetType().Name}");
        Console.WriteLine($"Площа: {CalculateArea()}");
        Console.WriteLine($"Периметр: {CalculatePerimeter()}");
    }
}
