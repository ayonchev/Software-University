using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class AnonymousVox
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] placeholders = Console.ReadLine()
                .Split(new char[] { '{', '}' },
                StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            string pattern = @"(\w+[^0-9])([^{}]+)(\1)";

            foreach (Match m in Regex.Matches(encodedText, pattern))
            {
                foreach (var group in m.Groups)
                {
                    if (group != m)
                    {
                        Console.WriteLine(group);
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
