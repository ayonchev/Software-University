using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<char, char> letterChecker = new Dictionary<char, char>();
            bool areExchangable = false;

            string firstWord = input[0];
            string secondWord = input[1];

            if (firstWord.Length == secondWord.Length)
            {
                areExchangable = AreExchangable(letterChecker, firstWord, secondWord);
            }
            else
            {
                string longerWord = "";
                string shorterWord = "";

                if (firstWord.Length > secondWord.Length)
                {
                    longerWord = firstWord;
                    shorterWord = secondWord;
                }
                else
                {
                    longerWord = secondWord;
                    shorterWord = firstWord;
                }

                areExchangable = AreExchangable(letterChecker, shorterWord, longerWord);
            }

            Console.WriteLine(areExchangable.ToString().ToLower());
        }

        static bool AreExchangable(Dictionary<char, char> letterChecker, string shorterWord, string longerWord)
        {
            for (int i = 0; i < shorterWord.Length; i++)
            {
                if (!letterChecker.ContainsKey(shorterWord[i]))
                {
                    if (letterChecker.ContainsValue(longerWord[i]))
                    {
                        return false;
                    }
                    else
                    {
                        letterChecker.Add(shorterWord[i], longerWord[i]);
                    }
                }
                else
                {
                    if (letterChecker[shorterWord[i]] != longerWord[i])
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (shorterWord.Length != longerWord.Length)
            {
                for (int i = 0; i < longerWord.Length; i++)
                {
                    if (!letterChecker.ContainsValue(longerWord[i]))
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return true;
        }
    }
}
