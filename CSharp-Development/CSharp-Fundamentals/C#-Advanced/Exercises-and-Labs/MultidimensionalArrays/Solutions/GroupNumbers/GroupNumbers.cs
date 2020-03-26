using System;
using System.Linq;

namespace GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] resultArray = new int[3][];

            int[] firstRow = numbers.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            int[] secondRow = numbers.Where(x => Math.Abs(x) % 3 == 1).ToArray();
            int[] thirdRow = numbers.Where(x => Math.Abs(x) % 3 == 2).ToArray();

            resultArray[0] = firstRow;
            resultArray[1] = secondRow;
            resultArray[2] = thirdRow;

            for (int row = 0; row < resultArray.Length; row++)
            {
                for (int column = 0; column < resultArray[row].Length; column++)
                {
                    Console.Write(resultArray[row][column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
