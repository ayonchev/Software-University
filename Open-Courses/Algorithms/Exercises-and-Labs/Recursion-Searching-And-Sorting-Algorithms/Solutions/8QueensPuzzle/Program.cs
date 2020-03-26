using System;

namespace _8QueensPuzzle
{
    class Program
    {
        const int size = 8;
        // -1, -2, .. -7 - attacked position
        //  0 - empty position
        //  1 - queen
        static int[,] chessboard = new int[size, size];
        static int numberOfSolutions = 0;
        static int numberOfQueens = 0;
        static void Main(string[] args)
        {
            PlaceQueens();
            Console.WriteLine(numberOfSolutions);
        }

        static void PlaceQueens(int row = 0)
        {
            if(numberOfQueens == size)
            {
                numberOfSolutions++;
                PrintSolution();
                return;
            }
            else
            {
                for (int column = 0; column < size; column++)
                {
                    if(CanPlaceQueen(row, column))
                    {
                        PlaceOrRemoveQueen(row, column, false);
                        MarkOrUnmarkAttackedPositions(row, column, false);

                        PlaceQueens(row + 1);

                        MarkOrUnmarkAttackedPositions(row, column, true);
                        PlaceOrRemoveQueen(row, column, true);
                    }
                }
            }
        }

        static bool CanPlaceQueen(int row, int column)
        {
            return chessboard[row, column] == 0;
        }

        static void PlaceOrRemoveQueen(int row, int column, bool shouldRemoveQueen)
        {
            if(shouldRemoveQueen)
            {
                chessboard[row, column] = 0;
                numberOfQueens--;
            }
            else
            {
                chessboard[row, column] = 1;
                numberOfQueens++;
            }
        }

        static void MarkOrUnmarkAttackedPositions(int row, int column, bool shouldUnmarkAttackedPositions)
        {
            int positionSign = -1;
            if (shouldUnmarkAttackedPositions)
                positionSign = 1;

            //mark row
            for (int columnIndex = 0; columnIndex < size; columnIndex++)
            {
                if (columnIndex == column)
                    continue;

                chessboard[row, columnIndex] += positionSign;
            }

            //mark column
            for (int rowIndex = 0; rowIndex < size; rowIndex++)
            {
                if (rowIndex == row)
                    continue;

                chessboard[rowIndex, column] += positionSign;
            }

            //mark left diagonal
            int leftDiagonalheight = Math.Min(row, column);
            int leftDiagonalStartRow = row - leftDiagonalheight;
            int leftDiagonalStartColumn = column - leftDiagonalheight;

            while(leftDiagonalStartColumn < size && leftDiagonalStartRow < size)
            {
                if (leftDiagonalStartRow == row && leftDiagonalStartColumn == column)
                {
                    leftDiagonalStartRow++;
                    leftDiagonalStartColumn++;
                    continue;
                }

                chessboard[leftDiagonalStartRow, leftDiagonalStartColumn] += positionSign;
                leftDiagonalStartRow++;
                leftDiagonalStartColumn++;
            }

            //mark right diagonal
            int rightDiagonalHeight = Math.Min(size - 1 - column, row - 0);
            int rightDiagonalStartRow = row - rightDiagonalHeight;
            int rightDiagonalColumnStart = column + rightDiagonalHeight;

            while (rightDiagonalStartRow < size && rightDiagonalColumnStart >= 0)
            {
                if (rightDiagonalStartRow == row && rightDiagonalColumnStart == column)
                {
                    rightDiagonalStartRow++;
                    rightDiagonalColumnStart--;
                    continue;
                }

                chessboard[rightDiagonalStartRow, rightDiagonalColumnStart] += positionSign;
                rightDiagonalStartRow++;
                rightDiagonalColumnStart--;
            }
        }

        static void PrintSolution()
        {
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    char output = '-';
                    if (chessboard[row, column] > 0)
                        output = '*';

                    Console.Write(output + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
