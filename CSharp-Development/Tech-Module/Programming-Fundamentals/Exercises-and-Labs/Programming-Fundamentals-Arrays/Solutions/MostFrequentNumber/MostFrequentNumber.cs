using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int countMostFrequentNumber = 0;
            int countLastMostFrequentNumber = 0;
            int mostFrequentNum = 0;
            int lastMostFrequentNum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                countMostFrequentNumber = 0;
                for (int k = 0; k < inputArray.Length; k++)
                {
                    if (inputArray[i] == inputArray[k])
                    {
                        countMostFrequentNumber++;
                        mostFrequentNum = inputArray[i];
                    }
                }

                if (countMostFrequentNumber > countLastMostFrequentNumber)
                {
                    countLastMostFrequentNumber = countMostFrequentNumber;
                    lastMostFrequentNum = mostFrequentNum;
                }
            }

            Console.WriteLine(lastMostFrequentNum);
        }
    }
}
