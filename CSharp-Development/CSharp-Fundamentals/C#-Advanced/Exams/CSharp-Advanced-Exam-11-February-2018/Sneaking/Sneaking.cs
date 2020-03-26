using System;
using System.Collections.Generic;
using System.Linq;

namespace Sneaking
{
    class Sneaking
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] resultJaggedArray = new char[rows][];
            bool isSamDead = false;
            bool isNikoladzeDead = false;

            for (int row = 0; row < rows; row++)
            {
                resultJaggedArray[row] = Console.ReadLine().ToCharArray();
            }

            int columns = resultJaggedArray[0].Length;

            int[] samsPosition = FindPlayer(resultJaggedArray, 'S');
            int samsRow = samsPosition[0];
            int samsColumn = samsPosition[1];

            string commands = Console.ReadLine();

            for (int index = 0; index < commands.Length; index++)
            {
                char currentCommand = commands[index];

                resultJaggedArray = MoveEnemies(resultJaggedArray, samsRow, samsColumn);

                if (FindPlayer(resultJaggedArray, 'X') != null)
                {
                    isSamDead = true;
                    samsPosition = FindPlayer(resultJaggedArray, 'X');
                    samsRow = samsPosition[0];
                    samsColumn = samsPosition[1];
                }
                else if (FindPlayer(resultJaggedArray, 'S') != null && FindPlayer(resultJaggedArray, 'N') != null)
                {
                    int[] samsCurrentPosition = FindPlayer(resultJaggedArray, 'S');
                    int[] nikoladzeCurrentPosition = FindPlayer(resultJaggedArray, 'N');

                    if (samsCurrentPosition[0] == nikoladzeCurrentPosition[0])
                    {
                        isNikoladzeDead = true;
                        samsColumn = Array.IndexOf(resultJaggedArray[samsCurrentPosition[0]], 'N');
                        resultJaggedArray[samsCurrentPosition[0]][samsColumn] = 'X';
                    }
                }

                if (isSamDead || isNikoladzeDead)
                {
                    break;
                }

                int newRow = samsRow;
                int newColumn = samsColumn;
                switch (currentCommand)
                {
                    case 'U':
                        resultJaggedArray[samsRow - 1][samsColumn] = 'S';
                        newRow = samsRow - 1;
                        resultJaggedArray[samsRow][samsColumn] = '.';
                        break;
                    case 'D':
                        resultJaggedArray[samsRow + 1][samsColumn] = 'S';
                        newRow = samsRow + 1;
                        resultJaggedArray[samsRow][samsColumn] = '.';
                        break;
                    case 'L':
                        resultJaggedArray[samsRow][samsColumn - 1] = 'S';
                        newColumn = samsColumn - 1;
                        resultJaggedArray[samsRow][samsColumn] = '.';
                        break;
                    case 'R':
                        resultJaggedArray[samsRow][samsColumn + 1] = 'S';
                        newColumn = samsColumn + 1;
                        resultJaggedArray[samsRow][samsColumn] = '.';
                        break;
                }
                
                samsRow = newRow;
                samsColumn = newColumn;

                if (resultJaggedArray[samsRow].Contains('N'))
                {
                    isNikoladzeDead = true;
                    samsColumn = Array.IndexOf(resultJaggedArray[samsRow], 'N');
                    resultJaggedArray[samsRow][samsColumn] = 'X';
                }

                if (isNikoladzeDead || isSamDead)
                {
                    break;
                }

            }

            if (isNikoladzeDead)
            {
                Console.WriteLine("Nikoladze killed!");
            }
            else
            {
                Console.WriteLine($"Sam died at {samsRow}, {samsColumn}");
            }

            PrintResult(resultJaggedArray);
        }


        static Queue<int[]> FindEnemies(char[][] input)
        {
            char[][] resultJaggedArray = (char[][])input.Clone();
            Queue<int[]> result = new Queue<int[]>();

            int rows = input.Length;
            int columns = input[0].Length;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (resultJaggedArray[row][column] == 'b' || resultJaggedArray[row][column] == 'd')
                    {
                        result.Enqueue(new[] { row, column });
                    }
                }
            }

            return result;
        }
        static char[][] MoveEnemies(char[][] input, int samsRow, int samsColumn)
        {
            char[][] resultJaggedArray = (char[][])input.Clone();

            int rows = input.Length;
            int columns = input[0].Length;

            Queue<int[]> numbers = FindEnemies(resultJaggedArray);

            foreach (var position in numbers)
            {
                int row = position[0];
                int column = position[1];

                if (resultJaggedArray[row][column] == 'b')
                {
                    if (column == columns - 1)
                    {
                        resultJaggedArray[row][column] = 'd';
                    }
                    else
                    {
                        resultJaggedArray[row][column] = '.';
                        resultJaggedArray[row][column + 1] = 'b';
                    }
                }
                else if (resultJaggedArray[row][column] == 'd')
                {
                    if (column == 0)
                    {
                        resultJaggedArray[row][column] = 'b';
                    }
                    else
                    {
                        resultJaggedArray[row][column] = '.';
                        resultJaggedArray[row][column - 1] = 'd';
                    }
                }

                if ((samsRow == row && samsColumn < column && resultJaggedArray[row][column] == 'd') ||
                    (samsRow == row && samsColumn > column && resultJaggedArray[row][column] == 'b'))
                {
                    samsRow = row;
                    samsColumn = Array.IndexOf(resultJaggedArray[row], 'S');
                    resultJaggedArray[samsRow][samsColumn] = 'X';
                    break;
                }
            }
            return resultJaggedArray;
        }
        static int[] FindPlayer(char[][] input, char player)
        {
            for (int row = 0; row < input.Length; row++)
            {
                for (int column = 0; column < input[row].Length; column++)
                {
                    if (input[row][column] == player)
                    {
                        return new[] { row, column };
                    }
                }
            }
            return null;
        }
        static void PrintResult(char[][] result)
        {
            for (int row = 0; row < result.Length; row++)
            {
                for (int column = 0; column < result[row].Length; column++)
                {
                    Console.Write(result[row][column]);
                }
                Console.WriteLine();
            }
        }
    }
}