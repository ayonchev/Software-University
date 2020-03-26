using System;
using System.Linq;

namespace SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            int[,] inputMatrix = MatrixFill(rows, columns);

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxColumn = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int column = 0; column < columns - 2; column++)
                {
                    int currentSum = inputMatrix[row, column] + inputMatrix[row, column + 1] + inputMatrix[row, column + 2] +
                                     inputMatrix[row + 1, column] + inputMatrix[row + 1, column + 1] + inputMatrix[row + 1, column + 2] +
                                     inputMatrix[row + 2, column] + inputMatrix[row + 2, column + 1] + inputMatrix[row + 2, column + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxColumn = column;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{inputMatrix[maxRow, maxColumn]} {inputMatrix[maxRow, maxColumn + 1]} {inputMatrix[maxRow, maxColumn + 2]}");
            Console.WriteLine($"{inputMatrix[maxRow + 1, maxColumn]} {inputMatrix[maxRow + 1, maxColumn + 1]} {inputMatrix[maxRow + 1, maxColumn + 2]}");
            Console.WriteLine($"{inputMatrix[maxRow + 2, maxColumn]} {inputMatrix[maxRow + 2, maxColumn + 1]} {inputMatrix[maxRow + 2, maxColumn + 2]}");
        }

        static int[,] MatrixFill(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = currentRow[column];
                }
            }

            return matrix;
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
