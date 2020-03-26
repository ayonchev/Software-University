using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            ReversingAndSummingArray(inputArray, rotations);
        }

        static void ReversingAndSummingArray(int[] inputArray, int rotations)
        {
            int[] lastArray = inputArray;

            int[] resultArray = new int[inputArray.Length];

            for (int i = 0; i < rotations; i++)
            {
                //variable for reversing the last reversed array; if it hasn't been reversed yet it equals the input array
                int[] reversedArray = new int[inputArray.Length];
                //scanning the array
                for (int k = 0; k < inputArray.Length; k++)
                {
                    //giving the first element of the reversed array the last element of the inputArray
                    if (k == 0)
                    {
                        reversedArray[k] = lastArray[inputArray.Length - 1];
                    }
                    //giving every element of the reversed array, the previous element of the inputArray
                    else
                    {
                        reversedArray[k] = lastArray[k - 1];
                    }
                }

                //summing the elements of all the reversed arrays
                for (int j = 0; j < inputArray.Length; j++)
                {
                    resultArray[j] += reversedArray[j];
                }
                //storing the last reverted array
                lastArray = reversedArray;
            }

            //Printing the result array
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
        }
    }
}
