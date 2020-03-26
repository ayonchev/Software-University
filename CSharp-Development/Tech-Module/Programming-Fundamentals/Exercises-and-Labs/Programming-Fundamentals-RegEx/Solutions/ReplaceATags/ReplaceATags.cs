using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATags
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                else
                {
                    string pattern = @"\B<a.*?href=(.*?)>(.*?)<\/a>\B";
                    
                    string replacement = @"[URL href=$1]$2[/URL]";

                    string replaced = Regex.Replace(input, pattern, replacement);

                    Console.WriteLine(replaced);
                }
            }
        }
    }
}
