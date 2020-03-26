using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            StringBuilder result = new StringBuilder();

            int sum = 0;
            int number = 0;
            int remainder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sum = firstNumber[i] - 48 + secondNumber[i] - 48 + remainder;
                number = sum % 10;

                result.Append(number);

                remainder = sum / 10;

                if (i == 0 && remainder > 0)
                {
                    result.Append(remainder);
                }
            }

            Console.WriteLine(new string(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}
