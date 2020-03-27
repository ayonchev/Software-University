using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure.ToLower() == "triangle")
            {
                Console.WriteLine(TriangleArea());
            }
            else if (figure.ToLower() == "rectangle")
            {
                Console.WriteLine(RectArea());
            }
            else if (figure.ToLower() == "square")
            {
                Console.WriteLine(SquareArea());
            }
            else if (figure.ToLower() == "circle")
            {
                Console.WriteLine(CircleArea());
            }
        }

        static double RectArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return Math.Round(width * height, 2);
        }

        static double SquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            return Math.Round(side * side, 2);
        }

        static double CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            return Math.Round(Math.PI * radius * radius, 2);
        }

        static double TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return Math.Round(side * height / 2, 2);
        }
    }
}
