using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            //Not 100 points!
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool printed = false;

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = i + 1; j < firstArr.Length; j++)
                {
                    for (int k = 0; k < firstArr.Length; k++)
                    {
                        if (firstArr[i] + firstArr[j] == firstArr[k])
                        {
                            Console.WriteLine(firstArr[i] + " + " + firstArr[j] + " == " + firstArr[k]);
                            printed = true;
                        }
                    }
                }
            }

            if (printed == false)
            {
                Console.WriteLine("No");

            }
        }
    }
}
