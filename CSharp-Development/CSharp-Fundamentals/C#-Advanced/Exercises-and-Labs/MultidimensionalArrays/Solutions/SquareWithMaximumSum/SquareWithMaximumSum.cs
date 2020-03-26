using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxColumn = 0;

            int[,] resultMatrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int column = 0; column < columns; column++)
                {
                    resultMatrix[row, column] = currentRow[column];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int column = 0; column < columns - 1; column++)
                {
                    int currentSum = resultMatrix[row, column] +
                                     resultMatrix[row, column + 1] +
                                     resultMatrix[row + 1, column] +
                                     resultMatrix[row + 1, column + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxColumn = column;
                    }
                }
            }

            Console.WriteLine(resultMatrix[maxRow, maxColumn] + " " + resultMatrix[maxRow, maxColumn + 1]);
            Console.WriteLine(resultMatrix[maxRow + 1, maxColumn] + " " + resultMatrix[maxRow + 1, maxColumn + 1]);
            Console.WriteLine(maxSum);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
