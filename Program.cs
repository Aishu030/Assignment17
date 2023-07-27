using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(14);
            circle.PrintInfo();
            Rectangle rectangle = new Rectangle(2.3, 11);
            rectangle.PrintInfo();
            Triangle triangle = new Triangle(33, 44, 55);
            triangle.PrintInfo();
            Console.WriteLine($"Circle -  Area: {circle.Area}, \t\tPerimeter: {circle.Perimeter}\n");
            Console.WriteLine($"Rectangle - Area: {rectangle.Area}, \t\t Perimeter: {rectangle.Perimeter}\n");
            Console.WriteLine($"Triangle -  Area: {triangle.Area}, \t\t Perimeter: {triangle.Perimeter}");
            Console.ReadKey();
        }
    }
}
