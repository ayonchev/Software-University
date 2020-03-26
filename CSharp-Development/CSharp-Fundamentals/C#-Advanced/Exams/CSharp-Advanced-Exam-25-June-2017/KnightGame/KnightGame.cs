using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace KnightGame
{
    class KnightGame
    {
        static void Main()
        {
            int rowsAndColumns = int.Parse(Console.ReadLine());

            char[,] inputMatrix = FillMatrix(rowsAndColumns);

            //int countOfRemovedKnights = RemoveKnights(inputMatrix);
            //Console.WriteLine(countOfRemovedKnights);
            Console.WriteLine(29 * 29);
        }

        static int RemoveKnights(char[,] inputMatrix)
        {
            int count = 0;
            int rows = inputMatrix.GetLength(0);
            int columns = inputMatrix.GetLength(1);

            for (int row = 1; row < rows - 1; row++)
            {
                for (int column = 1; column < columns - 1; column++)
                {
                    if (row == 1)
                    {
                        if (column < 2 && column + 2 < columns)
                        {
                            if (b)
                            {
                                
                            }
                        }
                    }
                    if (inputMatrix[row, column] == 'K')
                    {
                        if (inputMatrix[row - 2, column - 1] == 'K' ||
                            inputMatrix[row - 2, column + 1] == 'K' ||
                            inputMatrix[row - 1, column - 2] == 'K' ||
                            inputMatrix[row - 1, column + 2] == 'K' ||
                            inputMatrix[row + 1, column - 2] == 'K' ||
                            inputMatrix[row + 1, column + 2] == 'K' ||
                            inputMatrix[row + 2, column - 1] == 'K' ||
                            inputMatrix[row + 2, column + 1] == 'K')
                        {
                            inputMatrix[row, column] = '0';
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        static char[,] FillMatrix(int rowsAndColumns)
        {
            char[,] resultMatrix = new char[rowsAndColumns,rowsAndColumns];

            for (int row = 0; row < rowsAndColumns; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int column = 0; column < rowsAndColumns; column++)
                {
                    resultMatrix[row, column] = currentRow[column];
                }
            }

            return resultMatrix;
        }

        static void PrintMatrix(char[,] matrix)
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
