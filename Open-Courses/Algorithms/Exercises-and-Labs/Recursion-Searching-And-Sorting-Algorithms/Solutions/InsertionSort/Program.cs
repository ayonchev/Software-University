using System;
using System.Linq;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                Insert(array, i - 1, array[i]);
            }
        }

        static void Insert(int[] array, int rightIndex, int value)
        {
            int i = rightIndex;
            while (i >= 0 && array[i] > value)
            {
                array[i + 1] = array[i];
                i--;
            }
            array[i + 1] = value;
        }
    }
}
