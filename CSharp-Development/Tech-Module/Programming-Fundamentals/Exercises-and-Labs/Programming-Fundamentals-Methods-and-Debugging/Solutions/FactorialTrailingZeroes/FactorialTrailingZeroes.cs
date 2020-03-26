using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger resultNumber = NthFactorial();
            Console.WriteLine(NumberOfZeros(resultNumber));
        }

        static BigInteger NthFactorial()
        {
            long count = long.Parse(Console.ReadLine());
            BigInteger resultNumber = 1;

            for (int i = 1; i <= count; i++)
            {
                resultNumber *= i;
            }
            return resultNumber;
        }

        static BigInteger NumberOfZeros(BigInteger factorial)
        {
            int numberOfZeros = 0;
            BigInteger divisableNumber = 10;

            while (factorial % divisableNumber == 0)
            {
                numberOfZeros++;
                divisableNumber *= 10;
            }
            return numberOfZeros;
        }
    }
}
