using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CryptoBlockchain
{
    class CryptoBlockchain
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            string inputString = String.Empty;
            string pattern = @"((?<hash>\[)|\{)[^\{\}\]\[]*?(\d{3,})[^\{\}\]\[]*?(?(hash)\]|\})";

            for (int line = 0; line < lines; line++)
            {
                string currentString = Console.ReadLine();
                inputString += currentString;
            }

            string result = String.Empty;

            foreach (Match match in Regex.Matches(inputString, pattern))
            {
                string currentNumber = match.Groups[2].Value;

                string numberToAdd = "";
                if (currentNumber.Length % 3 == 0)
                {
                    for (int index = 0; index < currentNumber.Length; index++)
                    {
                        if (numberToAdd.Length == 3)
                        {
                            result += (char)(int.Parse(numberToAdd) - match.ToString().Length);
                            numberToAdd = String.Empty;
                        }
                        numberToAdd += currentNumber[index];
                    }
                    result += (char)(int.Parse(numberToAdd) - match.ToString().Length);
                }
            }

            Console.WriteLine(result);
        }
    }
}
