using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            bool isPalindrome = false;

            foreach (var word in text)
            {

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - i - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                    else
                    {
                        isPalindrome = true;
                    }
                }

                if (isPalindrome || word.Length == 1)
                {
                    if (!result.Any(x => x == word))
                    {
                        result.Add(word);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", result.OrderBy(x => x)));
        }
    }
}
