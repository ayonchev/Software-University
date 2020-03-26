using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int pair = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int k = 0; k < inputArray.Length; k++)
                {
                    if (inputArray[i] - inputArray[k] == difference)
                    {
                        pair++;
                    }
                }
            }
            Console.WriteLine(pair);
        }
    }
}
