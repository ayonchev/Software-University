using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameLastDigit
{
    class EnglishNameLastDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastDigitName());
        }
        /*static string GetLastDigitName()
        {
            string input = Console.ReadLine();
            char lastDigit = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                lastDigit = input[i];
            }

            string lastDigitName = "";

            switch (lastDigit)
            {
                case '0':
                    lastDigitName = "zero";
                    break;
                case '1':
                    lastDigitName = "one";
                    break;
                case '2':
                    lastDigitName = "two";
                    break;
                case '3':
                    lastDigitName = "three";
                    break;
                case '4':
                    lastDigitName = "four";
                    break;
                case '5':
                    lastDigitName = "five";
                    break;
                case '6':
                    lastDigitName = "six";
                    break;
                case '7':
                    lastDigitName = "seven";
                    break;
                case '8':
                    lastDigitName = "eight";
                    break;
                case '9':
                    lastDigitName = "nine";
                    break;
            }

            return lastDigitName;
        }*/
        static string GetLastDigitName()
        {
            long input = Math.Abs(long.Parse(Console.ReadLine()));
            long lastDigit = input % 10;
            string lastDigitName = "";

            switch (lastDigit)
            {
                case 0:
                    lastDigitName = "zero";
                    break;
                case 1:
                    lastDigitName = "one";
                    break;
                case 2:
                    lastDigitName = "two";
                    break;
                case 3:
                    lastDigitName = "three";
                    break;
                case 4:
                    lastDigitName = "four";
                    break;
                case 5:
                    lastDigitName = "five";
                    break;
                case 6:
                    lastDigitName = "six";
                    break;
                case 7:
                    lastDigitName = "seven";
                    break;
                case 8:
                    lastDigitName = "eight";
                    break;
                case 9:
                    lastDigitName = "nine";
                    break;
            }

            return lastDigitName;
        }
    }
}
