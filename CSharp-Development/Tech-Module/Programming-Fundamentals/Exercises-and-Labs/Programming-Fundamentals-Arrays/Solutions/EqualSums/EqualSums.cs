using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            int currIndex = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int k = 0; k < i; k++)
                {
                    leftSum += inputArray[k];
                }

                currIndex = i;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    rightSum += inputArray[j];
                }

                if (leftSum == rightSum)
                {
                    break;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(currIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
