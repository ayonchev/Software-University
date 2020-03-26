using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            double[] inputArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var result = inputArray.OrderByDescending(x => x).Take(3);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
