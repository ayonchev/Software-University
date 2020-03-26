using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            List<char> symbolsUsed = new List<char>();
            string currentPattern = "";
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsDigit(input[i]))
                {
                    currentPattern += input[i];
                }
                else
                {
                    int currentNumber = 0;

                    if (i + 1 < input.Length)
                    {
                        if (Char.IsDigit(input[i + 1]))
                        {
                            string currentNumberInStr = input[i].ToString() + input[i + 1];
                            currentNumber = int.Parse(currentNumberInStr);
                            i++;
                        }
                        else
                        {
                            currentNumber = (int)Char.GetNumericValue(input[i]);
                        }
                    }
                    else
                    {
                        currentNumber = (int)Char.GetNumericValue(input[i]);
                    }

                    result.Append(string.Concat(Enumerable.Repeat(currentPattern, currentNumber)));
                    currentPattern = "";
                }
            }

            symbolsUsed = result.ToString().Distinct().ToList();

            if (result.Length != 0)
            {
                Console.WriteLine("Unique symbols used: " + symbolsUsed.Count);
                Console.WriteLine(result);
            }
        }
    }
}
