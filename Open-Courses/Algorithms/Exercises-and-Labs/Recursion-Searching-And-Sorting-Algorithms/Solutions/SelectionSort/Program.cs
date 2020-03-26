using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new []{ 1, -1, 5, 12, -33, 68, 2, 144 };
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //Console.WriteLine("Initial sequence: " + string.Join(',', array));

            Sort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        static void Sort(int[] array)
        {
            for (int iterationsCount = 0; iterationsCount < array.Length; iterationsCount++)
            {
                int maxElement = int.MinValue;
                int maxElementIndex = 0;

                for (int index = 0; index < array.Length - iterationsCount; index++)
                {
                    int currentElement = array[index];

                    if(currentElement > maxElement)
                    {
                        maxElement = currentElement;
                        maxElementIndex = index;
                    }
                }

                int tempElement = array[array.Length - 1 - iterationsCount];
                array[array.Length - 1 - iterationsCount] = array[maxElementIndex];
                array[maxElementIndex] = tempElement;

                //Console.WriteLine($"Sequence after step {iterationsCount + 1}: {string.Join(',', array)}");
            }
        }
    }
}
