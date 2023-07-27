using System;
namespace Assignment17
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double A, double B, double C)
        {
            ShapeType = "Triangle";
            SideA = A;
            SideB = B;
            SideC = C;
        }

        public override double Area
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public override double Perimeter => SideA + SideB + SideC;

        public void PrintInfo()
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Length of SideA: {SideA}");
            Console.WriteLine($"Length of SideB: {SideB}");
            Console.WriteLine($"Length of SideC: {SideC}");
            Console.WriteLine("-----------------------------");
        }
    }
}
