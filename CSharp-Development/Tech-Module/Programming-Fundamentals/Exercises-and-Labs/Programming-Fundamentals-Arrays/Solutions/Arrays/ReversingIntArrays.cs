using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ReversingIntArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = newArray.Length -1; i >= 0; i--)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
