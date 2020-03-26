using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ParkingSystem
{
    class ParkingSystem
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            bool[,] resultMatrix = MatrixFill(rows, columns);

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "stop")
                {
                    int[] currentCar = input
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    int entryRow = currentCar[0];
                    int desiredRow = currentCar[1];
                    int desiredColumn = currentCar[2];

                    resultMatrix = CarMove(entryRow, desiredRow, desiredColumn, resultMatrix);
                }
                else
                {
                    break;
                }
            }
        }

        static bool[,] CarMove(int entryRow, int desiredRow, int desiredColumn, bool[,] inputMatrix)
        {
            bool[,] resultMatrix = (bool[,])inputMatrix.Clone();
            int parkingSpot = int.MaxValue;
            int count = 0;

            if (entryRow > desiredRow || entryRow < desiredRow)
            {
                count += Math.Abs(entryRow - desiredRow);
            }

            if (resultMatrix[desiredRow, desiredColumn] == true)
            {
                parkingSpot = desiredColumn;
            }
            else
            {
                for (int column = 1; column < resultMatrix.GetLength(1); column++)
                {
                    if (resultMatrix[desiredRow, column] == true && Math.Abs(desiredColumn - column) < parkingSpot)
                    {
                        parkingSpot = column;
                    }
                }
            }

            if (parkingSpot == int.MaxValue)
            {
                Console.WriteLine($"Row {desiredRow} full");
            }
            else
            {
                count += parkingSpot + 1;
                resultMatrix[desiredRow, parkingSpot] = false;
                Console.WriteLine(count);
            }

            return resultMatrix;
        }

        static bool[,] MatrixFill(int rows, int columns)
        {
            bool[,] matrix = new bool[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (column != 0)
                    {
                        matrix[row, column] = true;
                    }
                }
            }

            return matrix;
        }

        static void PrintMatrix(bool[,] matrix)
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
`