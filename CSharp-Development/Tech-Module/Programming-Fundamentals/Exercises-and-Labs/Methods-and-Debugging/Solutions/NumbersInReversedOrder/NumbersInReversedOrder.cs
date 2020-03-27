using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnReversedOrderNumbers());
        }

        static string ReturnReversedOrderNumbers()
        {
            string inputNumber = Console.ReadLine();
            string result = "";
            for (int i = inputNumber.Length - 1; i >= 0; i--)
            {
                result += inputNumber[i];
            }
            return result;
        }
    }
}
