using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            string firstString = string.Join("", firstArray);
            string secondString = string.Join("", secondArray);

            int c = firstString.CompareTo(secondString);

            if (c < 0)
            {
                Console.WriteLine(firstString);
                Console.WriteLine(secondString);
            }
            else
            {
                Console.WriteLine(secondString);
                Console.WriteLine(firstString);
            }
        }
    }
}
