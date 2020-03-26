using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '/', '\\', '(', ')' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length >= 3 && x.Length <= 25)
                .ToArray();

            string pattern = @"\b[a-zA-z][\w]+\b";

            List<string> usernames = new List<string>();

            foreach (var element in input)
            {
                if (Regex.IsMatch(element, pattern))
                {
                    usernames.Add(element);
                }
            }

            int maxLength = 0;
            int firstIndex = 0;
            int secondIndex = 0;

            for (int i = 0; i < usernames.Count - 1; i++)
            {
                if (usernames[i].Length + usernames[i + 1].Length > maxLength)
                {
                    maxLength = usernames[i].Length + usernames[i + 1].Length;
                    firstIndex = i;
                    secondIndex = i + 1;
                }
            }

            Console.WriteLine(usernames[firstIndex]);
            Console.WriteLine(usernames[secondIndex]);
        }
    }
}
