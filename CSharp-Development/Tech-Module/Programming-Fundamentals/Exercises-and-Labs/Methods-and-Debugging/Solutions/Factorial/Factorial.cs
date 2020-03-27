using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthFactorial());
        }

        static BigInteger NthFactorial()
        {
            long count = long.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= count; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
