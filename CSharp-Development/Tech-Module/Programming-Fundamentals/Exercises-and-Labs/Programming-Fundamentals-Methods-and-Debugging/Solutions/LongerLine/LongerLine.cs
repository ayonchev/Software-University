using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            WholeLine();
        }

        static void WholeLine()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            string firstPoint = $"({x1}, {y1})";
            string secondPoint = $"({x2}, {y2})";
            string thirdPoint = $"({x3}, {y3})";
            string fourthPoint = $"({x4}, {y4})";

            double firstLineX = Math.Abs(x1) + Math.Abs(x2);
            double secondLineX = Math.Abs(x3) + Math.Abs(x4);
            double firstLineY = Math.Abs(y1) + Math.Abs(y2);
            double secondLineY = Math.Abs(y3) + Math.Abs(y4);

            bool firstLine = false;
            bool secondLine = false;

            if ((firstLineX == secondLineX && firstLineY == secondLineY) || (firstLineX == firstLineY  && secondLineX == secondLineY))
            {
                firstLine = true;
            }
            else if (firstLineX > secondLineX || firstLineY > secondLineY)
            {
                firstLine = true;
            }
            else if (firstLineX < secondLineX || firstLineY < secondLineY)
            {
                secondLine = true;
            }

            if (firstLine == true)
            {
                CoordinatesNearestToCenterPoint(x1, y1, x2, y2);
            }
            else if (secondLine == true)
            {
                CoordinatesNearestToCenterPoint(x3, y3, x4, y4);
            }
        }

        static void CoordinatesNearestToCenterPoint(double firstX, double firstY, double secondX, double secondY)
        {
            string firstPoint = $"({firstX}, {firstY})";
            string secondPoint = $"({secondX}, {secondY})";

            firstX = Math.Abs(firstX);
            firstY = Math.Abs(firstY);
            secondX = Math.Abs(secondX);
            secondY = Math.Abs(secondY);

            if ((firstX == secondX && firstY == secondY) || (firstX == firstY && secondX == secondY))
            {
                Console.WriteLine($"{firstPoint}{secondPoint}");
            }
            else if (firstX > secondX || firstY > secondY)
            {
                Console.WriteLine($"{secondPoint}{firstPoint}");
            }
            else if (firstX < secondX || firstY < secondY)
            {
                Console.WriteLine($"{firstPoint}{secondPoint}");
            }
        }
    }
}
