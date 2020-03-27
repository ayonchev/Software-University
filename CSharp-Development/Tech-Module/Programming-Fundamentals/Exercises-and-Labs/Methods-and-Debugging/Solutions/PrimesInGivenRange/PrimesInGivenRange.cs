using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimesInRange(firstNumber, secondNumber));
        }
        static bool isNumPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static string PrimesInRange(int startingNumber, int endingNumber)
        {
            string result = "";
            bool isCurrNumPrime;

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                isCurrNumPrime = isNumPrime(i);
                if (isCurrNumPrime)
                {
                    result += i + ", ";
                }
            }
            result = result.Substring(0, result.Length - 2);
            return result;
        }
    }
}
