using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoops = int.Parse(Console.ReadLine());
            int[] arr = new int[numberOfLoops];
            Loop(0, arr);
        }

        static void Loop(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = 1; i <= arr.Length; i++)
            {
                arr[index] = i;
                Loop(index + 1, arr);
            }
        }
    }
}
