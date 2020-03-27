using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result += $"\\u{((int)(input[i])).ToString("X4").ToLower()}";
            }

            Console.WriteLine(result);
        }
    }
}
