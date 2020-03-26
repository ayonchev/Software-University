using System;
using System.Data;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] resultMatrix = MatrixFill(size, size);

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < size; row++)
            {
                firstDiagonal += resultMatrix[row, row];
                secondDiagonal += resultMatrix[row, size - row - 1];
            }

            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }

        static int[,] MatrixFill(int rows, int columns)
        {
            int[,] matrix = new int[rows,columns];

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
