using System;
using System.Linq;

namespace SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];
            int sum = 0;

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
                    sum += resultMatrix[row, column];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sum);
        }
    }
}
