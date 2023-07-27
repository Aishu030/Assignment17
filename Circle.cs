using System;
namespace Assignment17
{
   public class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            ShapeType = "Circle";
            Radius = r;
        }

        public override double Area => 3.14 * Radius * Radius;

        public override double Perimeter => 2 * 3.14 * Radius;

        public void PrintInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Radius: {Radius}");
        }
    }
}
