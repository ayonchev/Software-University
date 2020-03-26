using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
            }

            while (decimalNumber > 0)
            {
                result.Push(decimalNumber % 2);
                decimalNumber /= 2;
            }

            while (result.Count > 0)
            {
                Console.Write(result.Pop());   
            }
        }
    }
}
