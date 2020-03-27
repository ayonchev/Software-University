using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int number = 0;
            int remainder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("0");
                    break;
                }

                sum = ((firstNumber[i] - 48) * secondNumber) + remainder;
                number = sum % 10;

                result.Append(number);

                remainder = sum / 10;

                if (i == 0 && remainder > 0)
                {
                    result.Append(remainder);
                }
            }

            if (secondNumber != 0)
            {
                Console.WriteLine(new string(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
            }
        }
    }
}
