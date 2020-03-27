using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            BigInteger sum = 1;

            for (int i = 2; i <= count; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
