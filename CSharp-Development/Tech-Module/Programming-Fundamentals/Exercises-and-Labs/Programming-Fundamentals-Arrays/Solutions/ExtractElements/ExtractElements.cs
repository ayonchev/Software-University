using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractElements
{
    class ExtractElements
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (firstArr.Length == 1)
            {
                Console.WriteLine(firstArr[0]);
            }
            else if (firstArr.Length % 2 == 0)
            {
                for (int i = firstArr.Length / 2 - 1; i <= firstArr.Length / 2; i++)
                {
                    Console.Write(firstArr[i] + " ");
                }
            }
            else
            {
                for (int i = firstArr.Length / 2 - 1; i <= firstArr.Length / 2 + 1; i++)
                {
                    Console.Write(firstArr[i] + " ");
                }
            }
        }
    }
}
