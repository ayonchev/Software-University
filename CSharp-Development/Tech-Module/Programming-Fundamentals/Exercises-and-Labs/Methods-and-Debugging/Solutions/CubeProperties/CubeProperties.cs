using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            if (input.ToLower() == "face")
            {
                Console.WriteLine(Face(side));
            }
            else if (input.ToLower() == "volume")
            {
                Console.WriteLine($"{Volume(side):F2}");
            }
            else if (input.ToLower() == "space")
            {
                Console.WriteLine($"{Space(side):F2}");
            }
            else if (input.ToLower() == "area")
            {
                Console.WriteLine($"{Area(side):F2}");
            }
        }

        static double Face(double side)
        {
            return Math.Round(Math.Sqrt(2 * side * side), 2);
        }

        static double Volume(double side)
        {
            return (Math.Pow(side, 3));
        }

        static double Space(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        static double Area(double side)
        {
            return 6 * side * side;
        }
    }
}
