using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<long> result = new Stack<long>();

            result.Push(1);
            result.Push(1);

            for (int i = 0; i < n - 2; i++)
            {
                long previousNumber = result.Pop();
                long nextNumber = result.Peek() + previousNumber;

                result.Push(previousNumber);
                result.Push(nextNumber);
            }

            Console.WriteLine(result.Pop());
        }
    }
}
