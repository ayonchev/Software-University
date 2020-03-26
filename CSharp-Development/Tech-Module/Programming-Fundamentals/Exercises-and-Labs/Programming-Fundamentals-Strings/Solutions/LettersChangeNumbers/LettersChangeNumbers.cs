using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                string currentWord = inputArray[i];
                sum += CurrentSum(currentWord);
            }

            Console.WriteLine($"{sum:f2}");
        }

        static double CurrentSum(string currentWord)
        {
            double sum = 0;

            char firstLetter = currentWord.First();
            char lastLetter = currentWord.Last();

            double currentNumber = 0;
            
            currentNumber = double.Parse(currentWord.Substring(1, currentWord.Length - 2));

            if (Char.IsUpper(firstLetter))
            {
                sum = currentNumber / (firstLetter - 64);
            }
            else
            {
                sum = currentNumber * (firstLetter - 96);
            }

            if (Char.IsUpper(lastLetter))
            {
                sum -= (lastLetter - 64);
            }
            else
            {
                sum += (lastLetter - 96);
            }

            return sum;
        }
    }
}
