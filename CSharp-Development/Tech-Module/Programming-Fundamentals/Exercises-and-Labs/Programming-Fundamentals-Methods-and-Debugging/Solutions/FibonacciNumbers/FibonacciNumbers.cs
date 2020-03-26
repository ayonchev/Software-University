using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthFibonacciNumber());
        }

        static long NthFibonacciNumber()
        {
            int count = int.Parse(Console.ReadLine());
            long previousNumber = 1;
            long nextNumber = 0;
            long lastNumber = 0;

            //1 + 1 = 2
            //1 + 2 = 3
            //2 + 3 = 5
            //3 + 5 = 8
            for (int i = 0; i <= count; i++)
            {
                lastNumber = nextNumber;
                nextNumber = previousNumber + lastNumber;
                previousNumber = lastNumber;
            }
            return nextNumber;
        }
    }
}
