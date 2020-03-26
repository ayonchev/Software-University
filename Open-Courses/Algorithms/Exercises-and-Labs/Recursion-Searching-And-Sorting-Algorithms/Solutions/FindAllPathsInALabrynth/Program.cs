using System;
using System.Collections.Generic;
using System.Text;

namespace FindAllPathsInALabrynth
{
    class Program
    {
        static int rowSize;
        static int columnSize;
        static char[][] labyrinth;

        static char markedPosition = 'x';
        static char normalPosition = '-';
        static char forbiddenPosition = '*';
        static char endPosition = 'e';

        static StringBuilder path = new StringBuilder();
        static void Main(string[] args)
        {
            StoreInputData();
            //FindPaths(0, 0);
        }

        static void StoreInputData()
        {
            rowSize = int.Parse(Console.ReadLine());
            columnSize = int.Parse(Console.ReadLine());
            labyrinth = new char[rowSize][];

            for (int i = 0; i < rowSize; i++)
            {
                labyrinth[i] = Console.ReadLine().ToCharArray();
            }

            Console.WriteLine("-----------------");

            for (int row = 0; row < rowSize; row++)
            {
                Console.WriteLine(string.Join("", labyrinth[row]));
            }
        }

        static void FindPaths(int row, int column, string direction = "")
        {
            if(row < 0 || row >= rowSize || column < 0 || column >= columnSize ||
               labyrinth[row][column] == markedPosition || labyrinth[row][column] == forbiddenPosition) 
            {
                return;
            }
            else if (labyrinth[row][column] == endPosition)
            {
                MarkOrUnmarkPosition(row, column, direction, true);
                Console.WriteLine(path);
                MarkOrUnmarkPosition(row, column, direction, false);
                return;
            }
            else
            {
                MarkOrUnmarkPosition(row, column, direction, true);

                FindPaths(row, column + 1, "R");
                FindPaths(row + 1, column, "D");
                FindPaths(row - 1, column, "U");
                FindPaths(row, column - 1, "L");

                MarkOrUnmarkPosition(row, column, direction, false);
            }
        }

        static void MarkOrUnmarkPosition(int row, int column, string direction, bool shouldMark)
        {
            if(shouldMark)
            {
                if(labyrinth[row][column] != endPosition)
                    labyrinth[row][column] = markedPosition;
                path.Append(direction);
            }
            else
            {
                if (labyrinth[row][column] != endPosition)
                    labyrinth[row][column] = normalPosition;
                if(path.Length > 0)
                    path.Remove(path.Length - 1, 1);
            }
        }
    }
}
