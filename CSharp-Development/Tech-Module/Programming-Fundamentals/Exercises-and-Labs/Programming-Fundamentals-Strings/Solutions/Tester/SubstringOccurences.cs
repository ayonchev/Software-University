using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class SubstringOccurences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 0;
            int index = -1;

            while (true)
            {
                index = input.IndexOf(pattern, index + 1);
                if (index == -1)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
