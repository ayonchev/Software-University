using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumbers
{
    class CondensingArrays
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] condensed = new int[inputArray.Length - 1];

            while (condensed.Length >= 1)
            {
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = inputArray[i] + inputArray[i + 1];
                }

                inputArray = condensed;
                condensed = new int[inputArray.Length - 1];
            }

            Console.WriteLine(inputArray[0]);
        }
    }
}
