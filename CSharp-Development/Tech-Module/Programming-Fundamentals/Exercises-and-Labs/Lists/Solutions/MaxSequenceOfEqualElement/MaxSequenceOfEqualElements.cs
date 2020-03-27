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
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            MaxSequenceOfEqElements(inputList);
        }

        static void MaxSequenceOfEqElements(List<int> inputList)
        {
            int elementsOfSequence = 1;
            int sequenceNumber = 0;

            int longestSequence = 1;
            int currNumber = 0;

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    elementsOfSequence++;
                    currNumber = inputList[i];
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

            if (sequenceNumber == 0)
            {
                sequenceNumber = inputList[0];
            }

            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(sequenceNumber + " ");
            }
        }
    }
}