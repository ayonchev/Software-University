using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TargetPractice
{
    class TargetPractice
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];

            string snake = Console.ReadLine();

            int[] shotCharacteristics = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int impactRow = shotCharacteristics[0];
            int impactColumn = shotCharacteristics[1];
            int impactRadius = shotCharacteristics[2];

            char[,] resultMatrix = MatrixFill(rows, columns, snake);

            resultMatrix = KillSnakes(resultMatrix, impactRow, impactColumn, impactRadius);

            resultMatrix = CharactersFall(resultMatrix);

            PrintRows(resultMatrix);
        }

        static void PrintRows(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentWord = String.Empty;
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    currentWord += matrix[row, column];
                }
                Console.WriteLine(currentWord);
            }
        }

        static char[,] CharactersFall(char[,] matrix)
        {
            char[,] changedMatrix = (char[,])matrix.Clone();

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Stack<char> currentColumnSymbols = new Stack<char>();

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (changedMatrix[row, column] != ' ')
                    {
                        currentColumnSymbols.Push(changedMatrix[row, column]);
                    }
                }

                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    if (currentColumnSymbols.Count > 0)
                    {
                        changedMatrix[row, column] = currentColumnSymbols.Pop();
                    }
                    else
                    {
                        changedMatrix[row, column] = ' ';
                    }
                }
            }

            return changedMatrix;
        }

        static char[,] KillSnakes(char[,] matrix, int impactRow, int impactColumn, int impactRadius)
        {
            char[,] changedMatrix = (char[,])matrix.Clone();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (Math.Pow(row - impactRow, 2) + Math.Pow(column - impactColumn, 2) <= Math.Pow(impactRadius, 2))
                    {
                        changedMatrix[row, column] = ' ';
                    }
                }
            }

            return changedMatrix;
        }

        static char[,] MatrixFill(int rows, int columns, string snake)
        {
            char[,] matrix = new char[rows, columns];

            Queue<char> symbols = new Queue<char>(snake.ToCharArray());

            for (int row = rows - 1; row >= 0; row--)
            {
                for (int column = columns - 1; column >= 0; column--)
                {
                    if ((rows % 2 == 0 && row % 2 != 0) || (rows % 2 != 0 && row % 2 == 0))
                    {
                        matrix[row, column] = symbols.Peek();
                    }
                    else
                    {
                        matrix[row, columns - column - 1] = symbols.Peek();
                    }

                    symbols.Enqueue(symbols.Dequeue());
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
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
