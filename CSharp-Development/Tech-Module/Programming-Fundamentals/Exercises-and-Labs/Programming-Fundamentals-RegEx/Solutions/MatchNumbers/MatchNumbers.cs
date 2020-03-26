using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))\-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();

            var numbers = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
