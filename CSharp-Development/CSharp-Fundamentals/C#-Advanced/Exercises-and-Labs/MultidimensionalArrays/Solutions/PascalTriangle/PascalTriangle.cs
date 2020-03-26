using System;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            long[][] resultArray = new long[length][];

            for (int row = 0; row < resultArray.Length; row++)
            {
                long[] currentArray = new long[row + 1];

                for (int index = 0; index < currentArray.Length; index++)
                {
                    if (index == 0 || index == currentArray.Length - 1)
                    {
                        currentArray[index] = 1;
                    }
                    else
                    {
                        currentArray[index] = resultArray[row - 1][index] + resultArray[row - 1][index - 1];
                    }
                }
                resultArray[row] = currentArray;
            }

            //Printing the triangle
            for (int row = 0; row < resultArray.Length; row++)
            {
                for (int index = 0; index < resultArray[row].Length; index++)
                {
                    Console.Write(resultArray[row][index] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
