using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceEqElements
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            MaxSequenceOfEqElements(inputArray);
        }

        static void MaxSequenceOfEqElements(int[] inputArray)
        {
            int elementsOfSequence = 1;
            int sequenceNumber = 0;

            int longestSequence = 0;
            int currNumber = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    elementsOfSequence++;
                    currNumber = inputArray[i];
                }
                else
                {
                    elementsOfSequence = 1;
                }

                if (elementsOfSequence > longestSequence)
                {
                    longestSequence = elementsOfSequence;
                    sequenceNumber = currNumber;
                }
            }

            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(sequenceNumber + " ");
            }
        }
    }
}
