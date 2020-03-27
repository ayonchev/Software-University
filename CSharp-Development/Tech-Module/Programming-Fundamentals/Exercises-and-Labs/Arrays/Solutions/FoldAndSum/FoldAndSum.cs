using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstRowArray = new int[inputArray.Length / 2];
            int[] secondRowArray = new int[inputArray.Length / 2];

            int[] firstArray = new int[firstRowArray.Length / 2];
            int[] secondArray = new int[firstRowArray.Length / 2];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = inputArray[firstArray.Length - i - 1];
            }

            for (int i = 0; i < secondRowArray.Length; i++)
            {
                secondRowArray[i] = inputArray[i + firstArray.Length];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = inputArray[inputArray.Length - 1 - i];
            }

            firstArray.CopyTo(firstRowArray, 0);
            secondArray.CopyTo(firstRowArray, firstArray.Length);

            for (int i = 0; i < secondRowArray.Length; i++)
            {
                Console.Write(firstRowArray[i] + secondRowArray[i] + " ");
            }
        }
    }
}
