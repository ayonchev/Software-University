using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            string[] inputArray = 
                Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', ',', ';', '.', ':', '!', '[', ']', '\\', '/', '(', ')', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            var result = inputArray.Where(s => s.Length < 5).OrderBy(s => s);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
