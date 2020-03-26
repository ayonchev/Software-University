using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Sort(numbers, 0, numbers.Length - 1);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void Sort(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middleIndex = (int)Math.Floor((startIndex + endIndex) / 2.0);

                Sort(arr, startIndex, middleIndex);
                Sort(arr, middleIndex + 1, endIndex);
                Merge(arr, startIndex, middleIndex, endIndex);
            }
        }

        static void Merge(int[] arr, int startIndex, int middleIndex, int endIndex)
        {
            if (arr[middleIndex] < arr[middleIndex + 1])
                return;

            int[] leftHalf = new int[(middleIndex - startIndex) + 1];
            int[] rightHalf = new int[endIndex - middleIndex];

            for (int i = 0; i < leftHalf.Length; i++)
            {
                leftHalf[i] = arr[startIndex + i];
            }
            for (int i = 0; i < rightHalf.Length; i++)
            {
                rightHalf[i] = arr[middleIndex + i + 1];
            }

            int leftHalfIndex = 0;
            int rightHalfIndex = 0;

            for (int arrIndex = startIndex; arrIndex <= endIndex; arrIndex++)
            {
                if(leftHalfIndex == leftHalf.Length)
                {
                    arr[arrIndex] = rightHalf[rightHalfIndex];
                    rightHalfIndex++;
                }
                else if(rightHalfIndex == rightHalf.Length)
                {
                    arr[arrIndex] = leftHalf[leftHalfIndex];
                    leftHalfIndex++;
                }
                else if (leftHalf[leftHalfIndex] < rightHalf[rightHalfIndex])
                {
                    arr[arrIndex] = leftHalf[leftHalfIndex];
                    leftHalfIndex++;
                }
                else
                {
                    arr[arrIndex] = rightHalf[rightHalfIndex];
                    rightHalfIndex++;
                }
            }
        }
    }
}
