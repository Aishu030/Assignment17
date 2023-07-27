using System;
namespace Assignment17
{
    public class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double w, double h)
        {
            ShapeType = "Rectangle";
            Width = w;
            Height = h;
        }

        public override double Area => Width * Height;

        public override double Perimeter => 2 * (Width + Height);

        public void PrintInfo()
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
        }
    }
}
