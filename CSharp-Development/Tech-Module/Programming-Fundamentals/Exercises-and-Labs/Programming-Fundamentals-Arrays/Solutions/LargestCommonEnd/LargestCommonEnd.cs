using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            int shorter = Math.Min(firstArray.Length, secondArray.Length);

            int leftSide = 0;
            int rightSide = 0;

            for (int i = 0; i < shorter; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftSide++;
                }
                else if(firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - i - 1])
                {
                    rightSide++;
                }
            }

            if (rightSide > leftSide)
            {
                Console.WriteLine(rightSide);
            }
            else
            {
                Console.WriteLine(leftSide);
            }
        }
    }
}
