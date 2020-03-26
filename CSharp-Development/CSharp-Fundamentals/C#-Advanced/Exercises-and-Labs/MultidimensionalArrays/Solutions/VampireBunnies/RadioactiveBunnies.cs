using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            char[,] resultMatrix = MatrixFill(rows, columns);

            string commands = Console.ReadLine();

            Stack<int[]> lastPosition = new Stack<int[]>();
            lastPosition.Push(FindPlayer(resultMatrix));
            int playerRow = lastPosition.Peek()[0];
            int playerColumn = lastPosition.Peek()[1];

            bool won = false;
            bool isDead = false;

            for (int command = 0; command < commands.Length; command++)
            {
                switch (commands[command])
                {
                    case 'L':
                        playerColumn--;
                        break;
                    case 'R':
                        playerColumn++;
                        break;
                    case 'U':
                        playerRow--;
                        break;
                    case 'D':
                        playerRow++;
                        break;
                }

                if (playerRow >= rows || playerRow < 0 || playerColumn >= columns || playerColumn < 0)
                {
                    won = true;
                    resultMatrix[lastPosition.Peek()[0], lastPosition.Peek()[1]] = '.';
                }
                else if (resultMatrix[playerRow, playerColumn] == 'B')
                {
                    isDead = true;
                }
                else
                {
                    resultMatrix[lastPosition.Peek()[0], lastPosition.Peek()[1]] = '.';
                    resultMatrix[playerRow, playerColumn] = 'P';
                }

                resultMatrix = BunniesSpread(resultMatrix);

                if (FindPlayer(resultMatrix)[0] == -1)
                {
                    isDead = true;
                }


                if (won)
                {
                    PrintMatrix(resultMatrix);
                    Console.WriteLine($"won: {lastPosition.Peek()[0]} {lastPosition.Peek()[1]}");
                    break;
                }
                else if (isDead == true)
                {
                    PrintMatrix(resultMatrix);
                    Console.WriteLine($"dead: {lastPosition.Peek()[0]} {lastPosition.Peek()[1]}");
                    break;
                }

                lastPosition.Pop();
                lastPosition.Push(new int[] { playerRow, playerColumn });
            }
        }

        static char[,] BunniesSpread(char[,] matrix)
        {
            char[,] resultMatrix = (char[,])matrix.Clone();
            int rows = resultMatrix.GetLength(0);
            int columns = resultMatrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (resultMatrix[row, column] == 'B')
                    {
                        if (row == 0)
                        {
                            if (column == 0)
                            {
                                resultMatrix[row, column + 1] = 'B';
                            }
                            else if (column == columns - 1)
                            {
                                resultMatrix[row, column - 1] = 'B';
                            }
                            else
                            {
                                resultMatrix[row, column + 1] = 'B';
                                resultMatrix[row, column - 1] = 'B';
                            }
                            resultMatrix[row + 1, column] = 'B';
                        }
                        else if (row == rows - 1)
                        {
                            if (column == 0)
                            {
                                resultMatrix[row, column + 1] = 'B';
                            }
                            else if (column == columns - 1)
                            {
                                resultMatrix[row, column - 1] = 'B';
                            }
                            else
                            {
                                resultMatrix[row, column - 1] = 'B';
                                resultMatrix[row, column + 1] = 'B';
                            }
                            resultMatrix[row - 1, column] = 'B';
                        }
                        else
                        {
                            if (column == 0)
                            {
                                resultMatrix[row, column + 1] = 'B';
                            }
                            else if (column == columns - 1)
                            {
                                resultMatrix[row, column - 1] = 'B';
                            }
                            else
                            {
                                resultMatrix[row, column - 1] = 'B';
                                resultMatrix[row, column + 1] = 'B';
                            }
                            resultMatrix[row - 1, column] = 'B';
                            resultMatrix[row + 1, column] = 'B';
                        }
                    }
                }
            }

            return resultMatrix;
        }

        static int[] FindPlayer(char[,] matrix)
        {
            int[] player = new int[2];
            player[0] = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] == 'P')
                    {
                        player[0] = row;
                        player[1] = column;
                        break;
                    }
                }
            }
            return player;
        }

        static char[,] MatrixFill(int rows, int columns)
        {
            char[,] matrix = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = currentRow[column];
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
