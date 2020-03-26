using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();

            string[] sentences = Console.ReadLine()
                .Split(new char[] {'!', '?', '.'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            string pattern = "\\b" + keyword + "\\b";

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
