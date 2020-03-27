using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceIncreasingEl
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            MaxSequenceOfIncreasingElements(inputArray);
        }

        static void MaxSequenceOfIncreasingElements(int[] inputArray)
        {
            int elementsOfSequence = 1;

            int longestSequence = 0;

            int startCurrIndex = 0;
            int startIndex = 0;

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] - inputArray[i - 1] >= 1)
                {
                    elementsOfSequence++;
                    startCurrIndex = i - elementsOfSequence + 1;

                    if (elementsOfSequence > longestSequence)
                    {
                        longestSequence = elementsOfSequence;
                        startIndex = startCurrIndex;
                    }
                }
                else
                {
                    elementsOfSequence = 1;
                }
            }


            for (int i = startIndex; i < longestSequence + startIndex; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }
    }
}
