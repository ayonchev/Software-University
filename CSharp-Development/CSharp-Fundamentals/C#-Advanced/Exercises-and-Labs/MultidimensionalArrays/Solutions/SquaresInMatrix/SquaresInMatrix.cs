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

            string[,] resultMatrix = MatrixFill(rows, columns);

            int countOfSquares = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int column = 0; column < columns - 1; column++)
                {
                    if (resultMatrix[row, column] == resultMatrix[row, column + 1] && 
                        resultMatrix[row+ 1, column] == resultMatrix[row + 1, column + 1] &&
                        resultMatrix[row, column] == resultMatrix[row + 1, column])
                    {
                        countOfSquares++;
                    }
                }
            }

            Console.WriteLine(countOfSquares);
        }

        static string[,] MatrixFill(int rows, int columns)
        {
            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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
