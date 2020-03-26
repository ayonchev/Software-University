using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] resultArray = new int[Max(firstArr, secondArr)];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
                Console.Write(resultArray[i] + " ");
            }
        }

        static int Max(int[] firstArr, int[] secondArr)
        {
            if (firstArr.Length >= secondArr.Length)
            {
                return firstArr.Length;
            }
            else
            {
                return secondArr.Length;
            }
        }
    }
}
