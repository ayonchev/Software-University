using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int endingNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endingNumber; i++)
            {
                if (EvenDigit(i) && IsPalindrome(i) && SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberInStr = Convert.ToString(number);
            bool isPalindrom = true;
            //string firstPart = "";
            //string secondPartReversed = "";

            //int firstPartEnd = numberInStr.Length / 2;
            //int secondPartStart = (int)Math.Ceiling((double)numberInStr.Length / 2);

            //Storing the first part
            /*for (int i = 0; i < numberInStr.Length / 2; i++)
            {
                firstPart += numberInStr[i];
            }

            //Reversing the second part
            for (int i = numberInStr.Length - 1; i >= secondPartStart; i--)
            {
                secondPartReversed += numberInStr[i];
            }

            if (firstPart == secondPartReversed)
            {
                return true;
            }
            return false;*/

            for (int i = 0; i < numberInStr.Length / 2; i++)
            {
                if (numberInStr[i] != numberInStr[numberInStr.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }

        static bool SumOfDigits(int number)
        {
            string numberInStr = Convert.ToString(number);
            int sum = 0;

            for (int i = 0; i < numberInStr.Length; i++)
            {
                sum += int.Parse(numberInStr[i].ToString());
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool EvenDigit(int number)
        {
            /*string numberInStr = Convert.ToString(number);

            for (int i = numberInStr.Length - 1; i >= 0 ; i--)
            {
                if (int.Parse(numberInStr[i].ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;*/

            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
