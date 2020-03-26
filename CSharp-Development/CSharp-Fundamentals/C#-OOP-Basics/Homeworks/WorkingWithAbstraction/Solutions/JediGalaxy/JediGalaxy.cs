using System;
using System.Data;
using System.Linq;

class JediGalaxy
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int columns = dimensions[1];

        int[,] matrix = MatrixFill(rows, columns);

        long sum = FindSumOfAllStars(matrix, rows, columns);

        Console.WriteLine(sum);

    }

    static long FindSumOfAllStars(int[,] matrix, int rows, int columns)
    {
        string command;
        long sum = 0;
        while ((command = Console.ReadLine()) != "Let the Force be with you")
        {
            int[] ivoCoordinates = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] evilCoordinates = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int evilRow = evilCoordinates[0];
            int evilColumn = evilCoordinates[1];

            DestroyStars(matrix, evilRow, evilColumn, rows, columns);

            int ivoRow = ivoCoordinates[0];
            int ivoColumn = ivoCoordinates[1];

            sum += CollectStars(matrix, ivoRow, ivoColumn, rows, columns);
        }

        return sum;
    }

    static long CollectStars(int[,] matrix, int ivoRow, int ivoColumn, int rows, int columns)
    {
        long sum = 0;

        while (ivoRow >= 0 && ivoColumn < columns)
        {
            if (ivoRow >= 0 && ivoRow < rows && ivoColumn >= 0 && ivoColumn < columns)
            {
                sum += matrix[ivoRow, ivoColumn];
            }

            ivoColumn++;
            ivoRow--;
        }

        return sum;
    }
    static void DestroyStars(int[,] matrix, int evilRow, int evilColumn, int rows, int columns)
    {
        while (evilRow >= 0 && evilColumn >= 0)
        {
            if (evilRow >= 0 && evilRow < rows && evilColumn >= 0 && evilColumn < columns)
            {
                matrix[evilRow, evilColumn] = 0;
            }
            evilRow--;
            evilColumn--;
        }
    }

    static int[,] MatrixFill(int rows, int columns)
    {
        int[,] matrix = new int[rows,columns];
        int value = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = value++;
            }
        }

        return matrix;
    }
}
