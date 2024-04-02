using System;

class Program
{
    static void Main(string[] args)
    {
        Figure[] figures = new Figure[3];
        figures[0] = new Rectangle(4, 5);
        figures[1] = new Circle(3);
        figures[2] = new Triangle(3, 4, 5);

        foreach (var figure in figures)
        {
            figure.PrintInfo();
            Console.WriteLine();
        }
    }
}
