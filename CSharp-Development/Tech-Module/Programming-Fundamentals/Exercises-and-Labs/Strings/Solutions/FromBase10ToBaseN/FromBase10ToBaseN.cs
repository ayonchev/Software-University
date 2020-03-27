using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FromBase10ToBaseN
{
    class FromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            BigInteger[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            BigInteger baseNumber = inputArr[0];
            BigInteger numberToConvert = inputArr[1];

            if (baseNumber >= 2 && baseNumber <= 10)
            {
                string reversedResult = "";
                string result = "";

                while (numberToConvert / baseNumber > 0)
                {
                    reversedResult += numberToConvert % baseNumber;
                    numberToConvert /= baseNumber;
                }

                reversedResult += numberToConvert % baseNumber;

                for (int i = reversedResult.Length - 1; i >= 0; i--)
                {
                    result += reversedResult[i];
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
