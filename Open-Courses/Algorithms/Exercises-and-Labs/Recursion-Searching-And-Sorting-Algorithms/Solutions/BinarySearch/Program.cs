using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToFind = int.Parse(Console.ReadLine());

            int index = FindIndex(array, numberToFind);
            Console.WriteLine(index);
        }

        static int FindIndex(int[] array, int numberToFind)
        {
            int minIndex = 0;
            int maxIndex = array.Length - 1;
            int halfIndex = (int)Math.Floor((minIndex + maxIndex) / 2.0);

            while (minIndex <= maxIndex)
            {
                if (array[halfIndex] == numberToFind)
                    return halfIndex;
                else if (array[halfIndex] > numberToFind)
                    maxIndex = halfIndex - 1;
                else
                    minIndex = halfIndex + 1;

                halfIndex = (int)Math.Floor((minIndex + maxIndex) / 2.0);
            }

            return -1;
        }
    }
}
