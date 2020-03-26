using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FromBaseNToBase10
{
    class FromBaseNToBase10
    {
        static void Main(string[] args)
        {
            BigInteger[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            BigInteger baseNumber = inputArr[0];
            BigInteger numberToConvert = inputArr[1];


            string reversedNumber = numberToConvert.ToString();
            string number = "";
            BigInteger result = 0;

            for (int i = reversedNumber.Length - 1; i >= 0; i--)
            {
                number += reversedNumber[i];
            }
                
            for (int i = 0; i < number.Length; i++)
            {
                result += (int)Char.GetNumericValue(number[i]) * BigInteger.Pow(baseNumber, i);
            }

            Console.WriteLine(result);
        }
    }
}
