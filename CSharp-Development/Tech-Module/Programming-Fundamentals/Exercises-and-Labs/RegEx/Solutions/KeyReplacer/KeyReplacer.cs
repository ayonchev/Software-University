using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();

            string keyStringPattern = @"^([a-zA-Z]+)(?:\<|\||\\).+(?:\<|\||\\)([a-zA-Z]+)$";

            string textString = Console.ReadLine();

            string startKey = Regex.Match(keyString, keyStringPattern).Groups[1].Value;

            string endKey = Regex.Match(keyString, keyStringPattern).Groups[2].Value;

            string textStringPattern = $"{startKey}(.*?){endKey}";

            string result = "";

            foreach (Match match in Regex.Matches(textString, textStringPattern))
            {
                result += match.Groups[1];
            }

            if (result == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
