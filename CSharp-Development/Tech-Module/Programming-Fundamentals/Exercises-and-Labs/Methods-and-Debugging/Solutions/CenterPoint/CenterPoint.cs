using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            CoordinatesNearestToCenterPoint();
        }

        static void CoordinatesNearestToCenterPoint()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            string firstPoint = $"({x1}, {y1})";
            string secondPoint = $"({x2}, {y2})";

            x1 = Math.Abs(x1);
            y1 = Math.Abs(y1);
            x2 = Math.Abs(x2);
            y2 = Math.Abs(y2);

            if ((x1 == x2 && y1 == y2) || (x1 == y1 && x2 == y2))
            {
                Console.WriteLine(firstPoint);
            }
            else if (x1 > x2 || y1 > y2)
            {
                Console.WriteLine(secondPoint);
            }
            else if (x1 < x2 || y1 < y2)
            {
                Console.WriteLine(firstPoint);
            }
        }
    }
}
