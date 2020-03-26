using System;

namespace CombinationsWithRepetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int pairLength = int.Parse(Console.ReadLine());

            int[] arr = new int[pairLength];
            GenerateCombinations(0, 1, arr, numberOfElements);
        }

        static void GenerateCombinations(int index, int border, int[] arr, int numberOfElements)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = border; i <= numberOfElements; i++)
            {
                arr[index] = i;
                GenerateCombinations(index + 1, i, arr, numberOfElements);
            }
        }
    }
}
