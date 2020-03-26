using System;
using System.Linq;

namespace RubiksMatrix
{
    class RubiksMatrix
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            int count = 1;
            int[,] changedMatrix = MatrixFill(rows, columns);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int command = 0; command < numberOfCommands; command++)
            {
                string[] currentCommand = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                changedMatrix = ChangeMatrix(currentCommand, changedMatrix);
                PrintMatrix(changedMatrix);
            }

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (count == changedMatrix[row, column])
                    {
                        Console.WriteLine("No swap required");   
                    }
                    else
                    {
                        int numberToFind = count;
                        int[] rowAndColumn = FindNumber(changedMatrix, numberToFind);
                        int numbersRow = rowAndColumn[0];
                        int numbersColumn = rowAndColumn[1];

                        var currNumber = changedMatrix[row, column];
                        changedMatrix[row, column] = changedMatrix[numbersRow, numbersColumn];
                        changedMatrix[numbersRow, numbersColumn] = currNumber;

                        Console.WriteLine($"Swap ({row}, {column}) with ({numbersRow}, {numbersColumn})");
                    }
                    count++;
                }
            }
        }

        static int[] FindNumber(int[,] matrix, int number)
        {
            int[] rowAndColumn = new int[2];
            rowAndColumn[0] = -1;
            rowAndColumn[1] = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column].Equals(number))
                    {
                        rowAndColumn[0] = row;
                        rowAndColumn[1] = column;
                        return rowAndColumn;
                    }
                }
            }

            return rowAndColumn;
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
        static int[,] ChangeMatrix(string[] command, int[,] matrix)
        {
            int[,] changedMatrix = (int[,])matrix.Clone();
            int rows = changedMatrix.GetLength(0);
            int columns = changedMatrix.GetLength(1);

            string direction = command[1].ToLower();
            int steps = int.Parse(command[2]);
            int currentRowOrColumn = int.Parse(command[0]);
            int previousNumber = 0;
            if (steps > rows && (direction == "down" || direction == "up"))
            {
                steps %= rows;
            }
            else if(steps > columns && (direction == "left" || direction == "right"))
            {
                steps %= columns;
            }

            for (int step = 0; step < steps; step++)
            {
                switch (direction)
                {
                    case "down":
                        for (int row = 0; row < rows; row++)
                        {
                            if (row == 0)
                            {
                                previousNumber = changedMatrix[row, currentRowOrColumn];
                                changedMatrix[row, currentRowOrColumn] = changedMatrix[rows - 1 - row, currentRowOrColumn];
                            }
                            else
                            {
                                var currentNumber = changedMatrix[row, currentRowOrColumn];
                                changedMatrix[row, currentRowOrColumn] = previousNumber;
                                previousNumber = currentNumber;
                            }
                        }
                        break;

                    case "up":
                        for (int row = rows - 1; row >= 0; row--)
                        {
                            if (row == rows - 1)
                            {
                                previousNumber = changedMatrix[row, currentRowOrColumn];
                                changedMatrix[row, currentRowOrColumn] = changedMatrix[rows - 1 - row, currentRowOrColumn];
                            }
                            else
                            {
                                var currentNumber = changedMatrix[row, currentRowOrColumn];
                                changedMatrix[row, currentRowOrColumn] = previousNumber;
                                previousNumber = currentNumber;
                            }
                        }
                        break;

                    case "left":
                        for (int column = columns - 1; column >= 0; column--)
                        {
                            if (column == rows - 1)
                            {
                                previousNumber = changedMatrix[currentRowOrColumn, column];
                                changedMatrix[currentRowOrColumn, column] = changedMatrix[currentRowOrColumn, columns - 1 - column];
                            }
                            else
                            {
                                var currentNumber = changedMatrix[currentRowOrColumn, column];
                                changedMatrix[currentRowOrColumn, column] = previousNumber;
                                previousNumber = currentNumber;
                            }
                        }
                        break;

                    case "right":
                        for (int column = 0; column < columns; column++)
                        {
                            if (column == 0)
                            {
                                previousNumber = changedMatrix[currentRowOrColumn, column];
                                changedMatrix[currentRowOrColumn, column] = changedMatrix[currentRowOrColumn, columns - 1 - column];
                            }
                            else
                            {
                                var currentNumber = changedMatrix[currentRowOrColumn, column];
                                changedMatrix[currentRowOrColumn, column] = previousNumber;
                                previousNumber = currentNumber;
                            }
                        }
                        break;
                }
            }

            return changedMatrix;
        }

        static int[,] MatrixFill(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            int currentNumber = 1;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = currentNumber;
                    currentNumber++;
                }
            }

            return matrix;
        }
    }
}
