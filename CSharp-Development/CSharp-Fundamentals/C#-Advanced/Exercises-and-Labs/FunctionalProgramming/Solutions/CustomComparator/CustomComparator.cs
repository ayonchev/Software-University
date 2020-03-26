using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Array.Sort(numbers);

            int[] evenNums = numbers.Where(x => x % 2 == 0).ToArray();
            int[] oddNums = numbers.Where(x => x % 2 != 0).ToArray();
            Console.WriteLine(string.Join(" ", evenNums) + " " + string.Join(" ", oddNums));
        }
    }
}
