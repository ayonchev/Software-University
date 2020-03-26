using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            arr = Reverse(0, arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static int[] Reverse(int index, int[] arr)
        {
            if (index == (int)Math.Ceiling(arr.Length / 2.0))
                return arr;

            int leftSideNum = arr[index];
            arr[index] = arr[arr.Length - 1 - index];
            arr[arr.Length - 1 - index] = leftSideNum;

            Reverse(index + 1, arr);

            return arr;
        }
    }
}
