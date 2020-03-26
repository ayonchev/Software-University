using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            bool result = IsPalindrome(word);
            Console.WriteLine(result);
        }

        static bool IsPalindrome(string str, int index = 0)
        {
            if (str.Length == 0)
                return true;

            if (str[index] != str[str.Length - 1 - index])
                return false;
            if (index == (int)Math.Floor((str.Length - 1) / 2.0))
                return true;

            bool result = IsPalindrome(str, index + 1);
            return result;
        }
    }
}
