using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {(int)input[i] - 97}");
            }
        }
    }
}
