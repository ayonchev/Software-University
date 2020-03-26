using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringMatrixRotation
{
    class StringMatrixRotation
    {
        static void Main()
        {
            string command = Console.ReadLine();
            string pattern = @"^Rotate\((\d+)\)$";

            int rotationDegrees = int.Parse(Regex.Match(command, pattern).Groups[1].Value);
            if (rotationDegrees > 360)
            {
                rotationDegrees %= 360;
            }

            Queue<string> allRows = new Queue<string>();
            int maxColumns = int.MinValue;

            while (true)
            {
                string currentRow = Console.ReadLine();

                if (currentRow != "END")
                {
                    allRows.Enqueue(currentRow);
                    if (currentRow.Length > maxColumns)
                    {
                        maxColumns = currentRow.Length;
                    }
                }
                else
                {
                    break;
                }
            }

            char[,] inputMatrix = MatrixFill(allRows, maxColumns);

            char[,] rotatedMatrix = RotateMatrix(inputMatrix, rotationDegrees);
            PrintMatrix(rotatedMatrix);
        }

        static char[,] RotateMatrix(char[,] inputMatrix, int rotationDegrees)
        {
            int matrixRows = inputMatrix.GetLength(0);
            int matrixColumns = inputMatrix.GetLength(1);


            if (rotationDegrees == 90)
            {
                char[,] rotatedMatrix = new char[matrixColumns, matrixRows];

                for (int row = matrixRows - 1; row >= 0; row--)
                {
                    for (int column = 0; column < matrixColumns; column++)
                    {
                        rotatedMatrix[column, matrixRows - row - 1] = inputMatrix[row, column];
                    }
                }

                return rotatedMatrix;
            }
            else if (rotationDegrees == 180)
            {
                char[,] rotatedMatrix = new char[matrixRows, matrixColumns];

                for (int row = matrixRows - 1; row >= 0; row--)
                {
                    for (int column = matrixColumns - 1; column >= 0; column--)
                    {
                        rotatedMatrix[matrixRows - row - 1, matrixColumns - column - 1] = inputMatrix[row, column];
                    }
                }

                return rotatedMatrix;
            }
            else if (rotationDegrees == 270)
            {
                char[,] rotatedMatrix = new char[matrixColumns, matrixRows];

                for (int row = 0; row < matrixRows; row++)
                {
                    for (int column = 0; column < matrixColumns; column++)
                    {
                        rotatedMatrix[matrixColumns - column - 1, row] = inputMatrix[row, column];
                    }
                }

                return rotatedMatrix;
            }

            return inputMatrix;
        }

        static char[,] MatrixFill(Queue<string> allRows, int maxColumns)
        {
            char[,] matrix = new char[allRows.Count, maxColumns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = allRows.Dequeue();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (column < currentRow.Length)
                    {
                        matrix[row, column] = currentRow[column];
                    }
                    else
                    {
                        matrix[row, column] = ' ';
                    }
                }
            }

            return matrix;
        }


        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
