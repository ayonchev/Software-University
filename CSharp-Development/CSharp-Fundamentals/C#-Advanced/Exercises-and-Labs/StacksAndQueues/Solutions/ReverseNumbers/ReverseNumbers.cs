using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(new char[] {' '}, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> result = new Stack<int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                result.Push(inputNumbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
