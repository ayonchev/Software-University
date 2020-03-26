using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersect
{
    class CirclesIntersect
    {
        static void Main(string[] args)
        {
            double[] firstCircleInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondCircleInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Circle firstCircle = new Circle()
            {
                X = firstCircleInput[0],
                Y = firstCircleInput[1],
                Radius = firstCircleInput[2]
            };

            Circle secondCircle = new Circle()
            {
                X = secondCircleInput[0],
                Y = secondCircleInput[1],
                Radius = secondCircleInput[2]
            };

            double diffX = Math.Abs(firstCircle.X - secondCircle.X);
            double diffY = Math.Abs(firstCircle.Y - secondCircle.Y);
            double distance = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

            if (distance <= firstCircle.Radius + secondCircle.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
