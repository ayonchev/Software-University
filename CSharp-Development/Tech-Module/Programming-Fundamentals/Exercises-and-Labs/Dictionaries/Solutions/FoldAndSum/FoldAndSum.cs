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

            int k = inputArray.Length / 4;

            int[] firstElements = inputArray.Take(k).Reverse().ToArray();
            int[] secondElements = inputArray.Skip(k + 2 * k).Take(k).Reverse().ToArray();

            int[] firstRow = firstElements.Concat(secondElements).ToArray();
            int[] secondRow = inputArray.Skip(k).Take(k * 2).ToArray();

            int[] result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
