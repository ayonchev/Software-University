using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> result = new Stack<char>();

            foreach (var letter in input)
            {
                result.Push(letter);
            }

            while (result.Count > 0)
            {
                Console.Write(result.Pop());
            }
        }
    }
}
