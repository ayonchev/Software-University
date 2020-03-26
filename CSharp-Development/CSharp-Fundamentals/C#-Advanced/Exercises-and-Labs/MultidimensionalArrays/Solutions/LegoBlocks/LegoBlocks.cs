using System;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] firstArray = ArrayFill(rows);
            int[][] secondArray = ArrayFill(rows);

            bool areArraysMatch = CheckIfArraysMatch(firstArray, secondArray);

            if (areArraysMatch)
            {
                int[][] resultArray = CombineArrays(firstArray, secondArray);

                for (int row = 0; row < resultArray.Length; row++)
                {
                    Console.WriteLine($"[{string.Join(", ", resultArray[row])}]");
                }
            }
            else
            {
                int numberOfCells = 0;

                for (int row = 0; row < rows; row++)
                {
                    numberOfCells += firstArray[row].Length + secondArray[row].Length;
                }

                Console.WriteLine($"The total number of cells is: {numberOfCells}");
            }
        }

        static int[][] CombineArrays(int[][] firstArray, int[][] secondArray)
        {
            int[][] resultArray = new int[firstArray.Length][];

            for (int row = 0; row < firstArray.Length; row++)
            {
                int[] currentRow = new int[firstArray[row].Length + secondArray[row].Length];
                int[] reversedArray = secondArray[row].Reverse().ToArray();
                int reversedArrayCount = 0;

                for (int index = 0; index < currentRow.Length; index++)
                {
                    if (index < firstArray[row].Length)
                    {
                        currentRow[index] = firstArray[row][index];
                    }
                    else
                    {
                        currentRow[index] = reversedArray[reversedArrayCount];
                        reversedArrayCount++;
                    }
                }
                resultArray[row] = currentRow;
            }

            return resultArray;
        }

        static bool CheckIfArraysMatch(int[][] firstArray, int[][] secondArray)
        {
            int firstRowLength = firstArray[0].Length + secondArray[0].Length;

            for (int row = 1; row < firstArray.Length; row++)
            {
                if (firstArray[row].Length + secondArray[row].Length != firstRowLength)
                {
                    return false;
                }
            }

            return true;
        }

        static int[][] ArrayFill(int rows)
        {
            int[][] resultArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                resultArray[row] = currentRow;
            }

            return resultArray;
        }
     }
}
