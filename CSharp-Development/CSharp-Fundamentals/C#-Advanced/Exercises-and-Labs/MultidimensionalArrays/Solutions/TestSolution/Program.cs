using System;
using System.Collections.Generic;
using System.Linq;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2,3, 4, 5, 6 };

            int closestTo3 = arr.OrderBy(x => Math.Abs(3 - x)).FirstOrDefault();

            Console.WriteLine(closestTo3);
        }
    }
}
