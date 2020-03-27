using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string pattern = @"([\w\.\-]+\@[A-z\-]+)(\.[A-z\-]+)+";

            string input = Console.ReadLine();

            foreach (var emailMatch in Regex.Matches(input, pattern))
            {
                string email = emailMatch.ToString();

                if (!(email.StartsWith("_") || email.StartsWith("-") || email.StartsWith(".") || email.EndsWith(".") || email.EndsWith("-") || email.EndsWith("_")))
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}
