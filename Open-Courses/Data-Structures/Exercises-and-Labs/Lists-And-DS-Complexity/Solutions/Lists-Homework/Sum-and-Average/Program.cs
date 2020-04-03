using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();

            words.Sort((a, b) => a.CompareTo(b));

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
